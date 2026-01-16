using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VehicleManagementSystem {
    public partial class Dashboard : Form {
        // Fields
        private WindowControls WindowActions;
        private IconButton currentActiveButton;
        private Panel leftBorderButton;

        private void InitializedButtonLeftBorder() {
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(10, 85);
            leftBorderButton.BackColor = System.Drawing.Color.White;
            panelMenu.Controls.Add(leftBorderButton);
        }

        public Dashboard() {
            InitializeComponent();
            InitializedButtonLeftBorder();
            ActivateButton(vehManagementBtn);
            WindowActions = new WindowControls(this);
        }

        private void ActivateButton(object senderBtn) {
            if (senderBtn != null) {
                DeactiveButton();

                currentActiveButton = senderBtn as IconButton;
                currentActiveButton.IconSize = 60;
                currentActiveButton.BackColor = System.Drawing.Color.FromArgb(67, 74, 81);

                leftBorderButton.Location = new Point(0, currentActiveButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
            }
        }

        private void DeactiveButton() {
            if (currentActiveButton != null) {
                currentActiveButton.IconSize = 50;
                currentActiveButton.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void menuBtn_Click(object sender, EventArgs e) {
            ActivateButton(sender);
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            WindowActions.Close();
        }

        // Maximize the Form
        private async void maximizeBtn_Click(object sender, EventArgs e) {
            await WindowActions.ToggleMaximize(maximizeBtn);
        }

        // Minimize Form
        private void minimizeBtn_Click(object sender, EventArgs e) {
            WindowActions.Minimize();
        }

        // Activate the Drag Ability for Header
        private void panelHeader_MouseDown(object sender, MouseEventArgs e) {
            WindowActions.Drag(e);
        }

        // Search Bar
        private void searchBar_TextChanged(object sender, EventArgs e) {

        }

        private void searchBar_Enter(object sender, EventArgs e) {
            searchButton.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255); ;
        }

        private void searchBar_Leave(object sender, EventArgs e) {
            searchButton.BorderColor = System.Drawing.Color.FromArgb(213, 218, 223);
        }
    }
}
