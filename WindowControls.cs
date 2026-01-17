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
        int steps = 15;
        Rectangle start = _form.Bounds;
        Rectangle target;

        if (!_isMaximized) {
            target = Screen.FromHandle(_form.Handle).WorkingArea;
            _isMaximized = true;
            btn.IconChar = IconChar.WindowRestore;
        } else {
            var screen = Screen.FromHandle(_form.Handle).WorkingArea;
            int x = (screen.Width - _originalBounds.Width) / 2;
            int y = (screen.Height - _originalBounds.Height) / 2;
            target = new Rectangle(x, y, _originalBounds.Width, _originalBounds.Height);

            _isMaximized = false;
            btn.IconChar = IconChar.WindowMaximize;
        }

        for (int i = 1; i <= steps; i++) {
            int nW = start.Width + (target.Width - start.Width) * i / steps;
            int nH = start.Height + (target.Height - start.Height) * i / steps;
            int nX = start.X + (target.X - start.X) * i / steps;
            int nY = start.Y + (target.Y - start.Y) * i / steps;

            _form.SetBounds(nX, nY, nW, nH);
            await Task.Delay(1);
        }
    }
}