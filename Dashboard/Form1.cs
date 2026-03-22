using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;
using LiveCharts.WinForms;
using System.Windows.Media;

namespace Dashboard
{
    public partial class Dashboard : Form
    {
        string connStr = "server=mysql-car-rental-ravenakira22-d25a.j.aivencloud.com;port=10681;database=testDb;uid=avnadmin;pwd=AVNS_KkSsK8DVbXftqWP322A;";

        private Timer pollingTimer;
        private string currentPeriod = "Monthly";
        private bool isRefreshing = false;
        private int lastBookingId = 0;
        private int lastVehicleCount = 0;

        public Dashboard()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadKPIsAsync();
            await LoadGraphAsync(currentPeriod);
            await LoadPieChartAsync();

            lastBookingId = await GetLatestBookingIdAsync();
            lastVehicleCount = await GetVehicleCountAsync();

            pollingTimer = new Timer();
            pollingTimer.Interval = 3000;
            pollingTimer.Tick += PollingTimer_Tick;
            pollingTimer.Start();
        }

        private async Task<int> GetLatestBookingIdAsync()
        {
            return await Task.Run(() =>
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    new MySqlCommand("SET SESSION sql_mode = ''", conn).ExecuteNonQuery();
                    return Convert.ToInt32(new MySqlCommand(
                        "SELECT IFNULL(MAX(BookingID), 0) FROM Bookings", conn).ExecuteScalar());
                }
            });
        }

        private async Task<int> GetVehicleCountAsync()
        {
            return await Task.Run(() =>
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    new MySqlCommand("SET SESSION sql_mode = ''", conn).ExecuteNonQuery();
                    return Convert.ToInt32(new MySqlCommand(
                        "SELECT COUNT(*) FROM Vehicles", conn).ExecuteScalar());
                }
            });
        }

        private async void PollingTimer_Tick(object sender, EventArgs e)
        {
            if (isRefreshing) return;

            int newBookingId = await GetLatestBookingIdAsync();
            int newVehicleCount = await GetVehicleCountAsync();

            if (newBookingId != lastBookingId || newVehicleCount != lastVehicleCount)
            {
                isRefreshing = true;
                lastBookingId = newBookingId;
                lastVehicleCount = newVehicleCount;

                try
                {
                    await LoadKPIsAsync();
                    await LoadGraphAsync(currentPeriod);
                    await LoadPieChartAsync();
                }
                finally
                {
                    isRefreshing = false;
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            pollingTimer?.Stop();
            pollingTimer?.Dispose();
            base.OnFormClosed(e);
        }

        // ==============================
        // KPI CARDS
        // ==============================
        private async Task LoadKPIsAsync()
        {
            await Task.Run(() =>
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    new MySqlCommand("SET SESSION sql_mode = ''", conn).ExecuteNonQuery();

                    double totalRevenue = Convert.ToDouble(new MySqlCommand(@"
                        SELECT IFNULL(SUM(TotalPrice), 0)
                        FROM Bookings
                        WHERE Status = 'Completed'
                          AND Deleted = 0
                    ", conn).ExecuteScalar());

                    int activeRentals = Convert.ToInt32(new MySqlCommand(
                        "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='Rented'", conn).ExecuteScalar());

                    int reservedCars = Convert.ToInt32(new MySqlCommand(
                        "SELECT COUNT(*) FROM Bookings WHERE Status='Reserved'", conn).ExecuteScalar());

                    int inMaintenance = Convert.ToInt32(new MySqlCommand(
                        "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='InMaintenance'", conn).ExecuteScalar());

                    int availableCars = Convert.ToInt32(new MySqlCommand(
                        "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='Available'", conn).ExecuteScalar());

                    int outOfService = Convert.ToInt32(new MySqlCommand(
                        "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='OutOfService'", conn).ExecuteScalar());

                    int completedRentals = Convert.ToInt32(new MySqlCommand(
                        "SELECT COUNT(*) FROM Bookings WHERE Status='Completed' AND Deleted = 0", conn).ExecuteScalar());

                    string mostRentedCar = "N/A";

                    string mostRentedQuery = @"
                        SELECT CarName, COUNT(*) AS RentalCount
                        FROM (
                            SELECT CONCAT(v.Manufacturer, ' ', v.Model) AS CarName
                            FROM Bookings b
                            JOIN Vehicles v ON b.VehicleVIN = v.VIN
                            WHERE b.Status IN ('Out', 'Completed')
                              AND b.Deleted = 0

                            UNION ALL

                            SELECT vehicle AS CarName
                            FROM KioskBookings

                        ) AS CombinedBookings
                        GROUP BY CarName
                        ORDER BY RentalCount DESC
                        LIMIT 1";

                    using (var cmd = new MySqlCommand(mostRentedQuery, conn))
                    {
                        var result = cmd.ExecuteScalar();
                        mostRentedCar = result?.ToString() ?? "N/A";
                    }

                    this.Invoke((MethodInvoker)delegate
                    {
                        totalRevenuelbl.Text = "₱" + totalRevenue.ToString("N2");
                        activeRentalslbl.Text = activeRentals.ToString();
                        ReservedCarslbl.Text = reservedCars.ToString();
                        InMaintenancelbl.Text = inMaintenance.ToString();
                        AvailableCarslbl.Text = availableCars.ToString();
                        OutOfServicelbl.Text = outOfService.ToString();
                        CompletedRentalslbl.Text = completedRentals.ToString();
                        MostRentedCarlbl.Text = mostRentedCar;
                    });
                }
            });
        }

        // ==============================
        // PIE CHART
        // ==============================
        private async Task<PieSeries> CreateSeriesAsync(string title, string query, Brush color)
        {
            int value = 0;
            await Task.Run(() =>
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    new MySqlCommand("SET SESSION sql_mode = ''", conn).ExecuteNonQuery();
                    value = Convert.ToInt32(new MySqlCommand(query, conn).ExecuteScalar());
                }
            });

            return new PieSeries
            {
                Title = title,
                Values = new ChartValues<int> { value },
                DataLabels = true,
                LabelPoint = point => $"{point.Participation:P0}",
                Fill = color,
                Stroke = Brushes.White,
                StrokeThickness = 2
            };
        }

        private async Task LoadPieChartAsync()
        {
            var seriesCollection = new SeriesCollection
            {
                await CreateSeriesAsync("Available",      "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='Available'",     Brushes.Green),
                await CreateSeriesAsync("Rented",         "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='Rented'",        Brushes.Blue),
                await CreateSeriesAsync("Reserved",       "SELECT COUNT(*) FROM Bookings WHERE Status='Reserved'",             Brushes.Orange),
                await CreateSeriesAsync("Maintenance",    "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='InMaintenance'", Brushes.Gold),
                await CreateSeriesAsync("Out of Service", "SELECT COUNT(*) FROM Vehicles WHERE CurrentStatus='OutOfService'",  Brushes.Red),
                await CreateSeriesAsync("Completed",      "SELECT COUNT(*) FROM Bookings WHERE Status='Completed'",            Brushes.Purple)
            };

            this.Invoke((MethodInvoker)delegate
            {
                pieChart1.Series = seriesCollection;
                pieChart1.LegendLocation = LegendLocation.Right;
            });
        }

        // ==============================
        // REVENUE CHART
        // ==============================
        private async Task LoadGraphAsync(string period)
        {
            List<string> labels = new List<string>();
            List<double> values = new List<double>();

            await Task.Run(() =>
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    new MySqlCommand("SET SESSION sql_mode = ''", conn).ExecuteNonQuery();

                    string query = "";

                    if (period == "Daily")
                    {
                        query = @"
                            SELECT
                                DATE_FORMAT(DATE(DateDue), '%b %d') AS dateLabel,
                                SUM(TotalPrice) AS revenue
                            FROM Bookings
                            WHERE Status = 'Completed'
                              AND Deleted = 0
                              AND DateDue IS NOT NULL
                            GROUP BY DATE(DateDue)
                            ORDER BY DATE(DateDue)
                        ";
                    }
                    else if (period == "Weekly")
                    {
                        query = @"
        SELECT
            CONCAT(
                DATE_FORMAT(DATE_SUB(MIN(DateDue), INTERVAL WEEKDAY(MIN(DateDue)) DAY), '%b %d'),
                ' - ',
                DATE_FORMAT(DATE_ADD(DATE_SUB(MIN(DateDue), INTERVAL WEEKDAY(MIN(DateDue)) DAY), INTERVAL 6 DAY), '%b %d')
            ) AS dateLabel,
            SUM(TotalPrice) AS revenue
        FROM Bookings
        WHERE Status = 'Completed'
          AND Deleted = 0
          AND DateDue IS NOT NULL
        GROUP BY YEAR(DateDue), WEEK(DateDue, 1)
        ORDER BY YEAR(DateDue), WEEK(DateDue, 1)
    ";
                    }
                    else
                    {
                        query = @"
                            SELECT
                                DATE_FORMAT(MIN(DateDue), '%b %Y') AS dateLabel,
                                SUM(TotalPrice) AS revenue
                            FROM Bookings
                            WHERE Status = 'Completed'
                              AND Deleted = 0
                              AND DateDue IS NOT NULL
                            GROUP BY YEAR(DateDue), MONTH(DateDue)
                            ORDER BY YEAR(DateDue), MONTH(DateDue)
                        ";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            labels.Add(reader["dateLabel"].ToString());
                            values.Add(Convert.ToDouble(reader["revenue"]));
                        }
                    }
                }
            });

            this.Invoke((MethodInvoker)delegate
            {
                SeriesCollection series = new SeriesCollection();

                if (period == "Daily")
                {
                    series.Add(new LineSeries
                    {
                        Title = "Daily Revenue",
                        Values = new ChartValues<double>(values),
                        DataLabels = true,
                        PointGeometrySize = 8
                    });
                }
                else if (period == "Weekly")
                {
                    series.Add(new LineSeries
                    {
                        Title = "Weekly Revenue",
                        Values = new ChartValues<double>(values),
                        DataLabels = true,
                        PointGeometrySize = 8
                    });
                }
                else
                {
                    series.Add(new ColumnSeries
                    {
                        Title = "Monthly Revenue",
                        Values = new ChartValues<double>(values),
                        DataLabels = true
                    });
                }

                revenueChart.Series = series;
                revenueChart.AxisX.Clear();
                revenueChart.AxisX.Add(new Axis { Labels = labels });
                revenueChart.AxisY.Clear();
                revenueChart.AxisY.Add(new Axis
                {
                    LabelFormatter = val => "₱" + val.ToString("N0"),
                    MinValue = 0
                });
            });
        }

        private async void btnDaily_Click(object sender, EventArgs e)
        {
            currentPeriod = "Daily";
            await LoadGraphAsync(currentPeriod);
        }

        private async void btnWeekly_Click(object sender, EventArgs e)
        {
            currentPeriod = "Weekly";
            await LoadGraphAsync(currentPeriod);
        }

        private async void btnMonthly_Click(object sender, EventArgs e)
        {
            currentPeriod = "Monthly";
            await LoadGraphAsync(currentPeriod);
        }

        private void mostrentedPnl_Paint(object sender, PaintEventArgs e) { }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e) { }
    }
}