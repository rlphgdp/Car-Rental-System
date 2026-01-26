using System;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Services.Interfaces;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Services.Implementations {
    public class VehicleServices : IVehicleService {

        public void AddVehicle(Vehicle vehicle) {
            Console.WriteLine(vehicle.VIN);
        }
    }
}
