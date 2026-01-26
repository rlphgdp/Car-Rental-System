
using System.Windows.Forms;

namespace VehicleManagementSystem.Classes {
    public static class NavigationHelper {
        private static Form ActiveForm;

        public static void OpenForm(Form childForm) {
            if (ActiveForm != null) {
                ActiveForm.Close();
            }
            frmMain.ChildFormContainer.Controls.Clear();
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            frmMain.ChildFormContainer.Controls.Add(childForm);
            frmMain.ChildFormContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
