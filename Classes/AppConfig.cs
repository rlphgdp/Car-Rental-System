using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace VehicleManagementSystem.Classes {
    public static class AppConfig {
        public static class Theme {
            public static readonly Color Primary = Color.FromArgb(42, 132, 191);
            public static readonly Color PrimaryText = Color.FromArgb(44, 44, 44);
            public static readonly Color SecondaryText = Color.Gray;
        }

        public static class Titles {
            public const string VehManagement = "Vehicle Management";
            public const string MaintenanceManagement = "Maintenance Management";
            public const string UserManagement = "User Management";
        }

        public static class SubTitles {
            public const string AddNewVehicle = "Adding new vehicle";
        }

        public static void SetDoubleBuffer(Control crtl, bool DoubleBuffered) {
            try {
                typeof(Control).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, crtl, new object[] { DoubleBuffered });
            } catch(Exception ex) {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

    }
}
