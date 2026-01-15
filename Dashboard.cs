using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace VehicleManagementSystem {
    public partial class Dashboard : Form {

        // Fields
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

    }
}
