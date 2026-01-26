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

        public void saveVehicle() {
            _view.showError("TEST");
        }
    }
}
