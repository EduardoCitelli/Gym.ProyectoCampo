namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Windows.Forms;

    public partial class GrupoFrm : FormABMBase
    {
        private GrupoUsuarios NuevoGrupo;
        private GrupoUsuariosController Controller;
        private readonly bool EsModificacion;

        public GrupoFrm(GrupoUsuariosController controller, bool EsModificacion, GrupoUsuarios grupo)
        {
            this.InitializeComponent();
            this.NuevoGrupo = grupo;
            this.Controller = controller;
            this.EsModificacion = EsModificacion;

            if (this.EsModificacion) this.InicializarModificacion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.EsModificacion)
            {
                this.NuevoGrupo.gus_Descripcion = txtNombre.Text;
            }
            else
            {
                this.NuevoGrupo = new GrupoUsuarios()
                {
                    gus_Descripcion = txtNombre.Text
                };
            }

            this.Controller.GuardarGrupo(this.NuevoGrupo, this.EsModificacion);

            this.DialogResult = DialogResult.OK;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void InicializarModificacion()
        {
            this.lblTitulo.Text = "Modificar Grupo";

            this.txtNombre.Text = this.NuevoGrupo.gus_Descripcion;
        }
    }
}
