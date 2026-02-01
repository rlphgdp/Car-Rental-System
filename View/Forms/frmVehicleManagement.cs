using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Presenters;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.UserControls;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Forms {
    public partial class frmVehicleManagement : Form, IVehicleManagementView {

        private vehicleManagementPresenter _presenter;

        public frmVehicleManagement() {
            InitializeComponent();
            _presenter = new vehicleManagementPresenter(this, new VehicleServices());
        }

        public void DisplayVehicles(List<VehicleDto> vehicles) {
            tableLayoutVehicles.SuspendLayout();

            tableLayoutVehicles.Controls.Clear();
            tableLayoutVehicles.RowStyles.Clear();
            tableLayoutVehicles.RowCount = 0;

            int col = 0;
            int row = 0;
            int maxCols = 4;

            foreach (var vehicle in vehicles) {
                if (col == 0) {
                    tableLayoutVehicles.RowCount++;
                    tableLayoutVehicles.RowStyles.Add(
                        new RowStyle(SizeType.AutoSize)
                    );
                }

                var card = new VehicleCardControl();
                //card.Bind(vehicle);
                card.Dock = DockStyle.Fill;
                card.Margin = new Padding(10);

                tableLayoutVehicles.Controls.Add(card, col, row);

                col++;
                if (col >= maxCols) {
                    col = 0;
                    row++;
                }
            }

            tableLayoutVehicles.ResumeLayout();
        }

        public void ShowError(string message) {
            MessageBox.Show(message, "Error");
        }

        private void frmVehicleManagement_Load(object sender, EventArgs e) {
            _presenter.LoadVehicles();
        }

        private void addNewVehBtn_Click(object sender, EventArgs e) {
            NavigationHelper.OpenForm(new frmAddNewVehicle());
            frmMain.Instance.AddHeaderLabel(AppConfig.SubTitles.AddNewVehicle);
        }

        // Automatically add Double Buffering to the whole form
        // Boilerplate From Stackoverflow
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        
    }
}
