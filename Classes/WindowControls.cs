using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using FontAwesome.Sharp;

public class WindowControls {
    private Form _form;
    private Rectangle _originalBounds;
    private bool _isMaximized = false;

    public WindowControls(Form formInput) {
        _form = formInput;

        // Add this function when the inputed form is shown
        _form.Shown += (s, e) => {
            _originalBounds = _form.Bounds;
        };
    }

    // DRAG FUNCTION BOILER PLATE
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    public void Drag(MouseEventArgs e) {
        if (e.Button == MouseButtons.Left && !_isMaximized) {
            ReleaseCapture();
            SendMessage(_form.Handle, 0x112, 0xf012, 0);
        }
    }

    public void Close() {
        _form.Close();
    }

    public void Minimize() {
        _form.WindowState = FormWindowState.Minimized;
    }

    public async Task ToggleMaximize(IconButton btn) {
        if (!_isMaximized) {
            _form.WindowState = FormWindowState.Maximized;
            _isMaximized = true;
            btn.IconChar = IconChar.WindowRestore;
        } else {
            _form.WindowState&= FormWindowState.Normal;
            _isMaximized = false;
            btn.IconChar = IconChar.WindowMaximize;
        }
    }
}