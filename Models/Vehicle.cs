using System;

namespace VehicleManagementSystem.Models {
    public class Vehicle {
        public int VehicleID { get; set; }

        // Identifiers
        public string VIN { get; set; }
        public string LicensePlate { get; set; }

        // Basic Info
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // Classification
        public string Category { get; set; }          // Economy, SUV, etc.
        public string FuelType { get; set; }           // Gasoline, Electric, etc.
        public string Transmission { get; set; }       // Automatic, Manual
        public int? SeatingCapacity { get; set; }

        // Purchase & Lifecycle
        public DateTime PurchaseDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public DateTime? PlannedDisposalDate { get; set; }

        // Usage & Status
        public int CurrentOdometerReading { get; set; }
        public string CurrentStatus { get; set; }      // Available, Rented, etc.
        public decimal DailyRate { get; set; }

        // Media & Notes
        public string ImagePath { get; set; }
        public string Notes { get; set; }

        // System fields
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
