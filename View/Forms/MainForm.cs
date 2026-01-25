using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using VehicleManagementSystem.Forms;
using VehicleManagementSystem.Classes;
using Guna.UI2.WinForms;

namespace VehicleManagementSystem {

    public partial class MainForm : Form {

        // Fields
        public static MainForm Instance { get; private set; }
        public static Panel ChildFormContainer { get; private set; }

        private WindowControls WindowActions;
        private UIRenderer MenuHandler;

        private Label labelComponent;

        private void LoadDefaultView() {
            //WindowActions.ToggleMaximize(maximizeBtn);
            NavigationHelper.OpenForm(new frmVehicleManagement());
            MenuHandler.ActivateButton(vehManagementBtn);
        }

        public MainForm() {
            Instance = this;
            InitializeComponent();

            // Initialize Helpers Classes
            WindowActions = new WindowControls(this);
            MenuHandler = new UIRenderer(panelMenu);

            ChildFormContainer = panelDesktop;
            LoadDefaultView();
        }

        public void AddHeaderLabel(string label) {
            labelComponent = new Label();

            labelComponent.Tag = label;
            labelComponent.AutoSize = true;
            labelComponent.ForeColor = AppConfig.Theme.Primary;
            labelComponent.BackColor = System.Drawing.Color.Transparent;
            labelComponent.Font = new Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelComponent.Location = new Point(labelPage.Right, labelPage.Location.Y);
            labelComponent.Text = "> " + label;
            labelComponent.TabIndex = 2;

            panelHeader.Controls.Add(labelComponent);

            labelComponent.Visible = true;
            labelComponent.BringToFront();
        }

        public void RemoveHeaderLabel() {
            if (labelComponent != null) {
                panelHeader.Controls.Remove(labelComponent);
            }
        }

        // Windows Actions
        private void CloseButton_Click(object sender, EventArgs e) => WindowActions.Close();
        private async void maximizeBtn_Click(object sender, EventArgs e) => await WindowActions.ToggleMaximize(maximizeBtn);
        private void minimizeBtn_Click(object sender, EventArgs e) => WindowActions.Minimize();
        private void panelHeader_MouseDown(object sender, MouseEventArgs e) => WindowActions.Drag(e);

        // Navigation Functions
        private void vehManagementBtn_Click(object sender, EventArgs e) {
            RemoveHeaderLabel();
            MenuHandler.ActivateButton(sender);
            labelPage.Text = AppConfig.Titles.VehManagement;
            NavigationHelper.OpenForm(new frmVehicleManagement());
        }

        private void maintenanceMangementBtn_Click(object sender, EventArgs e) {
            RemoveHeaderLabel();
            MenuHandler.ActivateButton(sender);
            labelPage.Text = AppConfig.Titles.MaintenanceManagement;
            NavigationHelper.OpenForm(new frmMaintenanceManagement());
        }

        // Make the scroll more responsive
        // Boiler plate from stacks overflow
        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x115 || m.Msg == 0x114) {
                if ((m.WParam.ToInt32() & 0xFFFF) == 5) {
                    m.WParam = (IntPtr)((m.WParam.ToInt32() & ~0xFFFF) | 4);
                }
            }
            base.WndProc(ref m);
        }
    }
}
