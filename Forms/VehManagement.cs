using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem;

namespace VehicleManagementSystem.Forms {
    public partial class VehManagement : Form {
        public VehManagement() {
            InitializeComponent();
        }

        private void addNewVehBtn_Click(object sender, EventArgs e) {
            Dashboard.Instance.OpenForm(new AddNewVeh());
            Dashboard.Instance.AddHeaderLabel("Adding new car");
        }
    }
}
