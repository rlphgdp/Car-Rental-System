using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Data {
    public static class VehicleEnums {
        public enum FuelType {
            Gasoline,
            Diesel,
            Electric
        }

        public enum Category {
            Van,
            Truck,
            Economy,
            Midsize,
            Luxury
        }

        public enum TransmissionType {
            Manual,
            Automatic,
            SemiAutomatic
        }
    }
}
