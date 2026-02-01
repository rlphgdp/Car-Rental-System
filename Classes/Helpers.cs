using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Classes {
    public static class Helpers {

        static public string SaveImageToAppData(string sourceImagePath, string subFolder) {
            string targetPath = Path.Combine(AppConfig.AppData.RootPath, AppConfig.AppData.ImagesPath, subFolder);

            Directory.CreateDirectory(targetPath);

            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(sourceImagePath);
            string destinationPath = Path.Combine(targetPath, fileName);

            File.Copy(sourceImagePath, destinationPath, true);

            return Path.Combine(AppConfig.AppData.ImagesPath, subFolder, fileName);
        }

        static public string ConvertToCapitalized(string value) {
            if(string.IsNullOrEmpty(value)) return value;

            string _value = value.Trim();

            return char.ToUpper(_value[0]) + _value.Substring(1);
        }

    }
}
