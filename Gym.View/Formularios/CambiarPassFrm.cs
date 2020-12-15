namespace Gym.View
{
    using Common.Cache;
    using Gym.Auditoria;
    using Gym.Controladora;
    using System;
    using System.Windows.Forms;

    public partial class CambiarPassFrm : Form
    {
        private readonly UsersController controller;
        private readonly LogService log;

        public CambiarPassFrm()
        {
            InitializeComponent();
            this.controller = new UsersController();
            this.log = LogService.GetInstancia();
        }

        private void btnCerrar_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = this.controller.Obtener(UserLogeado.IdUser);

                usuario.usu_Password = this.txtPass.GetValor();

                this.controller.Guardar(usuario, true);

                this.log.Log(Eventos.GuardadoExitoso, "Cambio de Contraseña", this.Name);

                MessageBox.Show("Contraseña Cambiada Exitosamente", "CAMBIAR PASS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.log.Log(Eventos.GuardadoFallido, "Error al Cambiar Contraseña", this.Name);
                MessageBox.Show(ex.Message, "CAMBIAR PASS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}