namespace Gym.View
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public partial class FormABMBase : Form
    {
        public FormABMBase()
        {
            this.InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormABMBase_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e) => this.FormABMBase_MouseDown(sender, e);
    }
}
