namespace Gym.View
{
    using Common;
    using Gym.Controladora;
    using System;
    using System.Text;
    using System.Windows.Forms;

    public partial class RecuperarPassFrm : Form
    {
        private UsersController controller;

        public RecuperarPassFrm()
        {
            InitializeComponent();
            this.controller = new UsersController();
        }

        private void btnCerrar_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var usuario = this.controller.ObtenerPorMail(this.txtMail.GetValor());

            if (usuario == null)
                MessageBox.Show("No se encuentra ningún usuario con el email ingresado, Pruebe nuevamente con otro email", "RECUPERAR CONTRASEÑA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    var randomCode = "";

                    var ran = new Random();

                    var randText = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

                    int Length_randText = randText.Length;

                    for (int i = 0; i < 5; i++)
                    {
                        randomCode += randText[ran.Next(Length_randText)];
                    }

                    usuario.usu_Password = randomCode;

                    this.controller.Guardar(usuario, true);

                    var mensaje = new StringBuilder();

                    mensaje.AppendLine($"Tu nueva contraseña es <b>{randomCode}</b>");

                    Mailer.EnviarMail(mensaje, this.txtMail.GetValor(), "RECUPERAR PASS");

                    MessageBox.Show("Se Reseteo la contraseña, verifique su casilla de correo");

                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
