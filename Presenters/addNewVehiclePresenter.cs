using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Presentor {
    public class addNewVehiclePresenter {
        IAddNewVehicleView _view;
        VehicleServices _vehicleServices;

        public addNewVehiclePresenter(IAddNewVehicleView view, VehicleServices vehicleServices) { 
            _view = view;
            _vehicleServices = vehicleServices;
        }

        //private string ValidateInputs(IAddNewVehicleView _inputs) {
        //    string[] ErrorMessage;
        //    if (string.IsNullOrWhiteSpace(_view.VehicleIdentificationNumber)) {
        //        _view.ShowError("VIN is required.");
                
        //    }

        //    return ErrorMessage;
        //}

        public void SaveVehicle() {
            

            if (string.IsNullOrWhiteSpace(_view.VehiclePlateNum)) {
                _view.ShowError("Plate Number is required.");
                return;
            }
        }

    }
}
