using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Presentor;
using VehicleManagementSystem.View.Interfaces;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Data.Enums;
using System.Collections.Generic;
using Guna.UI2.WinForms;

namespace VehicleManagementSystem.Forms {
    public partial class frmAddNewVehicle : Form, IAddNewVehicleView {
        private class InputFieldUI {
            public Guna2TextBox _TextBox;
            public Label _errorLabel;

            public InputFieldUI(Label errorLabel, Guna2TextBox textBox) {
                _errorLabel = errorLabel;
                _TextBox = textBox;
            }
        }

        private addNewVehiclePresenter _presenter;
        private Dictionary<AddNewVehicleInputEnums, InputFieldUI> _inputFieldMap;
        private string _tempSelectedImagePath;

        // Basic Vehicle Information
        public string VehicleIdentificationNumber => inputVehicleIdentificationNumber.Text;
        public string VehiclePlateNum => inputPlateNum.Text;
        public string VehicleModel => inputModel.Text;
        public string VehicleYearModel => inputYearModel.Text;
        public string VehicleCatergory => inputCategory.Text;
        public string VehicleManufacturer => inputManufacturer.Text;
        public string VehicleColor => inputColor.Text;
        public string VehicleImagePath => _tempSelectedImagePath;

        // Vehicle Purchase Details
        public string VehiclePurchaseDate => inputPurchaseDate.Text;
        public string VehiclePurchasePrice => inputPurchasePrice.Text;
        public string VehicleCurrentOdometer => inputCurrentOdometer.Text;

        // Vehicle Rental Details
        public string VehicleDailyRate => inputDailyRate.Text;
        public string VehicleFuelType => inputFuelType.Text;
        public string VehicleTransmissionType => inputTransmissionType.Text;
        public string VehicleSeatCapacity => inputSeatCapacity.Text;

        public void ShowError(string message) {
            MessageBox.Show(message, "Error");
        }

        public void SetFieldError(AddNewVehicleInputEnums field, string message) {
            if (_inputFieldMap.TryGetValue(field, out InputFieldUI inputField)) { 
                inputField._TextBox.BorderColor = Color.Red; 
                inputField._errorLabel.Text = message;
                inputField._errorLabel.Visible = true;
            }
        }

        private void ClearFieldError(InputFieldUI inputField) {
            inputField._TextBox.BorderColor = Color.FromArgb(213, 218, 223);
            inputField._errorLabel.Text = null;
            inputField._errorLabel.Visible = false;
        }

        public frmAddNewVehicle() {
            InitializeComponent();
            _presenter = new addNewVehiclePresenter(this, new VehicleServices());

            IntializeInputFieldMap();
            InitializeComboBoxOptions();
        }

        // Initialized inputFieldMap dictionary for error handling
        private void IntializeInputFieldMap() {
            _inputFieldMap = new Dictionary<AddNewVehicleInputEnums, InputFieldUI> {
                { AddNewVehicleInputEnums.VehicleIdentificationNumber,
                  new InputFieldUI(errorLabelVehicleIdentificationNumber, inputVehicleIdentificationNumber)
                }, { AddNewVehicleInputEnums.VehiclePlateNum,
                  new InputFieldUI(errorLabelPlateNum, inputPlateNum)
                }, { AddNewVehicleInputEnums.VehicleModel,
                  new InputFieldUI(errorLabelModel, inputModel)
                }, { AddNewVehicleInputEnums.VehicleManufacturer,
                  new InputFieldUI(errorLabelManufacturer, inputManufacturer)
                }, { AddNewVehicleInputEnums.VehicleColor,
                  new InputFieldUI(errorLabelColor, inputColor)
                }, { AddNewVehicleInputEnums.VehicleYearModel,
                  new InputFieldUI(errorLabelYearModel, inputYearModel)
                }, { AddNewVehicleInputEnums.VehiclePurchasePrice,
                  new InputFieldUI(errorLabelPurchasePrice, inputPurchasePrice)
                }, { AddNewVehicleInputEnums.VehicleCurrentOdometer,
                  new InputFieldUI(errorLabelCurrentOdometer, inputCurrentOdometer)
                }, { AddNewVehicleInputEnums.VehicleDailyRate,
                  new InputFieldUI(errorLabelDailyRate, inputDailyRate)
                }, { AddNewVehicleInputEnums.VehicleSeatCapacity,
                  new InputFieldUI(errorLabelSeatCapacity, inputSeatCapacity)
                },
            };

            foreach (var field in _inputFieldMap.Values) {
                field._TextBox.Enter += (s, e) => ClearFieldError(field);
            }
        }

        private void InitializeComboBoxOptions() {
            inputCategory.DataSource = Enum.GetValues(typeof(VehicleEnums.Category));
            inputFuelType.DataSource = Enum.GetValues(typeof(VehicleEnums.FuelType));
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

                    _tempSelectedImagePath = fullPath;

                    vehiclePictureBox.Image = Image.FromFile(fullPath);

                    closeImageBtn.Visible = true;
                    addImageBtn.Visible = false;

                }
            }
        }

        private void closeImageBtn_Click(object sender, EventArgs e) {
            if (vehiclePictureBox.Image != null) {
                vehiclePictureBox.Image.Dispose();
            }

            if (_tempSelectedImagePath != null) { 
                _tempSelectedImagePath = null;
            }

            closeImageBtn.Visible = false;
            addImageBtn.Visible = true;
        }
    }
}
