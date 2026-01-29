using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.View.Interfaces;
using VehicleManagementSystem.Data.Enums;
using System;

namespace VehicleManagementSystem.Presentor {
    public class addNewVehiclePresenter {
        IAddNewVehicleView _view;
        VehicleServices _vehicleServices;

        public addNewVehiclePresenter(IAddNewVehicleView view, VehicleServices vehicleServices) {
            _view = view;
            _vehicleServices = vehicleServices;
        }

        public void SaveVehicle() {
            if (!IsAllInputsValid(_view)) 
                return;
            
            _view.ShowError("SUCCESS");
        }

        private bool IsAllInputsValid(IAddNewVehicleView inputs) {
            bool hadNoError = true;

            if (!IsNumericInputsValid(inputs))
                hadNoError = false;

            if (!IsAllInputsFilledUp(inputs))
                hadNoError = false;

            return hadNoError;
        }

        private bool IsNumericInputsValid(IAddNewVehicleView inputs) {
            bool hadNoError = true;

            if (!Double.TryParse(inputs.VehicleDailyRate, out _)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleDailyRate, "Invalid Input");
                hadNoError = false;
            }

            if (!Double.TryParse(inputs.VehiclePurchasePrice, out _)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehiclePurchasePrice, "Invalid Input");
                hadNoError = false;
            }

            if (!Double.TryParse(inputs.VehicleCurrentOdometer, out _)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleCurrentOdometer, "Invalid Input");
                hadNoError = false;
            }

            if (!Double.TryParse(inputs.VehicleDailyRate, out _)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleDailyRate, "Invalid Input");
                hadNoError = false;
            }

            if (!int.TryParse(inputs.VehicleSeatCapacity, out _)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleSeatCapacity, "Invalid Input");
                hadNoError = false;
            }

            if (!int.TryParse(inputs.VehicleYearModel, out _)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleYearModel, "Invalid Input");
                hadNoError = false;
            }

            return hadNoError;
        }

        private bool IsAllInputsFilledUp(IAddNewVehicleView inputs) {
            bool hadNoError = true;

            if (string.IsNullOrWhiteSpace(inputs.VehicleIdentificationNumber)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleIdentificationNumber, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehiclePlateNum)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehiclePlateNum, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehicleColor)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleColor, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehicleManufacturer)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleManufacturer, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehicleModel)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleModel, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehicleYearModel)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleYearModel, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehiclePurchasePrice)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehiclePurchasePrice, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehicleCurrentOdometer)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleCurrentOdometer, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehicleSeatCapacity)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleSeatCapacity, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehicleDailyRate)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleDailyRate, "Required.");
                hadNoError = false;
            }

            return hadNoError;
        }

    } 
}
