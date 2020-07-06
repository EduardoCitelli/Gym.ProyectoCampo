namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Windows.Forms;

    public partial class UsuarioFrm : FormABMBase
    {
        private Users NuevoUsuario;
        private readonly UsersController Controller;
        private readonly bool EsModificacion;

        public UsuarioFrm(UsersController controller, bool EsModificacion, Users usuario)
        {
            this.InitializeComponent();
            this.Controller = controller;
            this.EsModificacion = EsModificacion;
            this.cboGrupo.Refrescar();

            if (this.EsModificacion) this.InicializarFormularioModificacion(usuario);            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.EsModificacion)
            {
                this.NuevoUsuario.usu_LoginName = this.txtUsuario.GetValor();
                this.NuevoUsuario.usu_Apellido = this.txtApellido.GetValor();
                this.NuevoUsuario.usu_Email = this.txtEmail.GetValor();
                this.NuevoUsuario.usu_Nombre = this.txtNombre.GetValor();
                this.NuevoUsuario.usu_Password = this.txtPass.GetValor();
                this.NuevoUsuario.usu_gus_Id = this.cboGrupo.GetValor().gus_Id;
            }
            else
            {
                this.NuevoUsuario = new Users()
                {
                    usu_LoginName = this.txtUsuario.GetValor(),
                    usu_Apellido = this.txtApellido.GetValor(),
                    usu_Email = this.txtEmail.GetValor(),
                    usu_Nombre = this.txtNombre.GetValor(),
                    usu_Password = this.txtPass.GetValor(),
                    usu_gus_Id = this.cboGrupo.GetValor().gus_Id
                };
            }            

            this.Controller.Guardar(this.NuevoUsuario, this.EsModificacion);

            this.DialogResult = DialogResult.OK;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }        

        private void InicializarFormularioModificacion(Users usuario)
        {
            this.lblTitulo.Text = "Modificar Usuario";

            this.NuevoUsuario = usuario;

            this.txtApellido.SetValor(usuario.usu_Apellido);

            this.txtEmail.SetValor(usuario.usu_Email);

            this.txtNombre.SetValor(usuario.usu_Nombre);

            this.txtPass.SetValor(usuario.usu_Password);

            this.txtPass.Habilitado = false;

            this.txtUsuario.SetValor(usuario.usu_LoginName);

            this.cboGrupo.SetValor(usuario.usu_gus_Id);
        }
    }
}
