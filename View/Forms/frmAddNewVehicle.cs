using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Presentor;
using VehicleManagementSystem.View.Interfaces;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.Data;

namespace VehicleManagementSystem.Forms {
    public partial class frmAddNewVehicle : Form, IAddNewVehicleView {
        addNewVehiclePresenter _presenter;


        // Basic Vehicle Information
        public string VehicleIdentificationNumber => inputVehicleIdentificationNumber.Text;
        public string VehiclePlateNum => inputPlateNum.Text;
        public string VehicleModel => inputModel.Text;
        public string VehicleYearModel => inputYearModel.Text;
        public string VehicleCatergory => inputCategory.Text;
        public string VehicleManufacturer => inputManufacturer.Text;
        public string VehicleColor => inputColor.Text;
        public string VehicleImagePath => "TEST";

        // Vehicle Purchase Details
        public string VehiclePurchaseDate => inputPurchaseDate.Text;
        public string VehiclePurchasePrice => inputPurchasePrice.Text;
        public string VehicleCurrentOdometer => InputOdometer.Text;

        // Vehicle Rental Details
        public string VehicleDailyRate => inputDailyRate.Text;
        public string VehicleFuelType => inputFuelType.Text;
        public string VehicleTransmissionType => inputTransmissionType.Text;
        public string VehicleSeatCapacity => inputSeatCapacity.Text;

        public void ShowError(string message) {
            MessageBox.Show(message, "Error");
        }

        public void SetError(string inputName, string message) {
            switch (inputName) {
                case "inputColor":
                    inputColor.ForeColor = Color.Red;
                    break;
            }
        }

        private Bitmap inputVehicleImage;

        public frmAddNewVehicle() {
            InitializeComponent();

            _presenter = new addNewVehiclePresenter(this, new VehicleServices());

            inputCategory.DataSource = Enum.GetValues(typeof(VehicleEnums.Category));
            inputFuelType.DataSource = Enum.GetValues(typeof (VehicleEnums.FuelType));
            inputTransmissionType.DataSource = Enum.GetValues(typeof(VehicleEnums.TransmissionType));
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            _presenter.SaveVehicle();
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            DialogResult cancelConfirmation = MessageBox.Show(
                "Are you sure you want to cancel adding new vehicle? This action cannot be undone.", 
                "Cancelation Confirmation", 
                MessageBoxButtons.YesNo
            );

            if (cancelConfirmation == DialogResult.Yes) {
                frmMain.Instance.RemoveHeaderLabel();
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
                openFileDialog.Title = "Select an image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                openFileDialog.Multiselect = false;

                

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    if (vehiclePictureBox.Image != null) {
                        vehiclePictureBox.Image.Dispose();
                    }

                    string fullPath = openFileDialog.FileName;
                    string fileNameOnly = Path.GetFileName(fullPath);

                    //byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                    //using (MemoryStream ms = new MemoryStream(imageBytes)) {
                    //    inputVehicleImage = new Bitmap(ms);
                    //}
                    vehiclePictureBox.Image = Image.FromFile(fullPath);

                    closeImageBtn.Visible = true;
                    addImageBtn.Visible = false;

                    //vehicleImageFilename.Text = fileNameOnly;
                }
            }
        }

        private void closeImageBtn_Click(object sender, EventArgs e) {
            if (vehiclePictureBox.Image != null) {
                vehiclePictureBox.Image.Dispose();
            }

            closeImageBtn.Visible = false;
            addImageBtn.Visible = true;
        }
    }
}
