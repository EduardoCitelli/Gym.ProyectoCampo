namespace Gym.View
{
    using System;    
    using System.Drawing;    
    using System.Windows.Forms;
    using System.Runtime.InteropServices;
    using Gym.Controladora;
    using Common.Cache;
    using Gym.Domain;
    using Gym.Auditoria;

    public partial class LoginFrm : Form
    {
        private UsersController controller;

        private UsersController Controller => this.controller ?? (this.controller = new UsersController());        

        public LoginFrm()
        {
            this.InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "Usuario")
            {
                this.txtUsuario.Text = string.Empty;

                this.txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == string.Empty)
            {
                this.txtUsuario.Text = "Usuario";

                this.txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (this.txtPass.Text == "Pass")
            {
                this.txtPass.Text = string.Empty;

                this.txtPass.ForeColor = Color.LightGray;

                this.txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (this.txtPass.Text == string.Empty)
            {
                this.txtPass.Text = "Pass";

                this.txtPass.ForeColor = Color.DimGray;

                this.txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();

        private void btnMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void LoginFrm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();

            SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        private void pnlLeft_MouseDown(object sender, MouseEventArgs e) => this.LoginFrm_MouseDown(sender, e);

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usuario = this.Controller.ObtenerUsuario(this.txtUsuario.Text, this.txtPass.Text);

            if (usuario != null)
            {
                this.InicializarUsuario(usuario);

                var log = LogService.InicializarLog(usuario.usu_Id, usuario.usu_Nombre);
                log.Log(Eventos.LoginExitoso, string.Empty, this.Name);

                var form = new MenuFrm();

                form.Show();

                form.FormClosed += this.LogOut;

                this.Hide();
            }
            else
            {
                var log = LogService.InicializarLog(0, string.Empty);
                log.Log(Eventos.LoginFallido, string.Empty, this.Name);

                MessageBox.Show("Usuario Incorrecto", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            this.txtPass.Text = "Pass";
            this.txtPass.UseSystemPasswordChar = false;
            this.txtPass.ForeColor = Color.DimGray;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.ForeColor = Color.DimGray;
            this.Show();
        }

        private void InicializarUsuario(Users usuario)
        {
            UserLogeado.IdUser = usuario.usu_Id;
            UserLogeado.UserName = usuario.usu_LoginName;
            UserLogeado.Nombre = usuario.usu_Nombre;
            UserLogeado.Apellido = usuario.usu_Apellido;
            UserLogeado.Email = usuario.usu_Email;
            UserLogeado.TipoUsuario = usuario.Grupo != null ? usuario.Grupo.gus_Descripcion : string.Empty;
            UserLogeado.NumeroTipoUsuario = usuario.Grupo.gus_Id;
        }
    }
}
