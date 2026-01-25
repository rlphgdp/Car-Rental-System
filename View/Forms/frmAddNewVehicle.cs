using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Forms {
    public partial class frmAddNewVehicle : Form, IAddNewVehicleView {

        // Basic Vehicle Information
        public string VehicleIdentificationNumber => inputVehicleIdentificationNumber.Text;
        public string VehiclePlateNum => inputPlateNum.Text;
        public string VehicleModel => inputModel.Text;
        public string VehicleYearModel => inputYearModel.Text;
        public string VehicleCatergory => inputCategory.Text;
        public string VehicleManufacturer => inputManufacturer.Text;
        public string VehicleColor => inputColor.Text;
        public Bitmap VehicleImage => inputVehicleImage == null
            ? null
            : new Bitmap(inputVehicleImage);

        // Vehicle Purchase Details
        public string VehiclePurchaseDate => inputPurchaseDate.Text;
        public string VehiclePurchasePrice => inputPurchasePrice.Text;
        public string VehicleCurrentOdometer => InputOdometer.Text;

        // Vehicle Rental Details
        public string VehicleDailyRate => inputDailyRate.Text;
        public string VehicleFuelType => inputFuelType.Text;
        public string VehicleTransmissionType => inputTransmissionType.Text;
        public string VehicleSeatCapacity => inputSeatCapacity.Text;


        private Bitmap inputVehicleImage;

        public frmAddNewVehicle() {
            InitializeComponent();

        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            DialogResult cancelConfirmation = MessageBox.Show("Are you sure you want to cancel adding new vehicle?", "Cancelation Confirmation", MessageBoxButtons.YesNo);

            if (cancelConfirmation == DialogResult.Yes) {
                NavigationHelper.OpenForm(new frmVehicleManagement());
            }
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

        private void addImageBtn_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {


                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    if (inputVehicleImage != null) {
                        inputVehicleImage.Dispose();
                    }

                    string fullPath = openFileDialog.FileName;
                    string fileNameOnly = System.IO.Path.GetFileName(fullPath);

                    byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                    using (MemoryStream ms = new MemoryStream(imageBytes)) {
                        inputVehicleImage = new Bitmap(ms);
                    }

                    vehicleImageFilename.Text = fileNameOnly;
                }
            }
        }

    }
}
