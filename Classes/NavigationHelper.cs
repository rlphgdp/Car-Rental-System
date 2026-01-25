using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem.Classes {
    public static class NavigationHelper {
        private static Form ActiveForm;

        public static void OpenForm(Form childForm) {
            if (ActiveForm != null) {
                ActiveForm.Close();
            }
            MainForm.Instance.RemoveHeaderLabel();
            MainForm.ChildFormContainer.Controls.Clear();
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainForm.ChildFormContainer.Controls.Add(childForm);
            MainForm.ChildFormContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
