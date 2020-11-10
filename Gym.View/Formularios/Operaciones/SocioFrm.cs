namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Windows.Forms;

    public partial class SocioFrm : FormABMBase
    {
        private readonly SociosController sociosController;
        private readonly bool EsModificacion;
        private Socios Socio;

        public SocioFrm(SociosController controller, Socios socio, bool esModificacion)
        {
            this.InitializeComponent();
            this.sociosController = controller;

            this.EsModificacion = esModificacion;

            this.comboSexo.Refrescar();

            if (esModificacion) this.InicializarModificacion(socio);
        }

        private void InicializarModificacion(Socios socio)
        {
            this.lblTitulo.Text = "Modificar Socio";

            this.Socio = socio;

            this.numCodigo.SetValor(this.Socio.soc_Codigo);
            this.numCodigo.Habilitado = false;

            this.txtNombre.SetValor(this.Socio.soc_Nombre);

            this.txtApellido.SetValor(this.Socio.soc_Apellido);

            this.numDni.SetValor(this.Socio.soc_Dni);

            this.numTelefono.SetValor(this.Socio.soc_Telefono);

            this.txtDomicilio.SetValor(this.Socio.soc_Domicilio);

            this.dtNacimiento.SetValor(this.Socio.soc_FechaNacimiento);

            this.txtEmail.SetValor(this.Socio.soc_Mail);

            this.comboSexo.SetValor(this.Socio.soc_Sexo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.Validar()) return;

            if (this.EsModificacion)
            {
                this.Socio.soc_Nombre = this.txtNombre.GetValor();

                this.Socio.soc_Apellido = this.txtApellido.GetValor();

                this.Socio.soc_Dni = this.numDni.GetValor();

                this.Socio.soc_Telefono = this.numTelefono.GetLongValor();

                this.Socio.soc_Domicilio = this.txtDomicilio.GetValor();

                this.Socio.soc_FechaNacimiento = this.dtNacimiento.GetValor().Value;
                
                this.Socio.soc_Mail = this.txtEmail.GetValor();

                this.Socio.soc_Sexo = this.comboSexo.GetValor();
            }
            else
            {
                this.Socio = new Socios()
                {
                    soc_Codigo = this.numCodigo.GetValor(),
                    soc_Nombre = this.txtNombre.GetValor(),
                    soc_Apellido = this.txtApellido.GetValor(),
                    soc_Dni = this.numDni.GetValor(),
                    soc_Telefono = this.numTelefono.GetLongValor(),
                    soc_Domicilio = this.txtDomicilio.GetValor(),
                    soc_FechaNacimiento = this.dtNacimiento.GetValor().Value,
                    soc_Mail = this.txtEmail.GetValor(),
                    soc_Sexo = this.comboSexo.GetValor()
                };
            }

            try
            {
                this.sociosController.Guardar(this.Socio, this.EsModificacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }           

            this.DialogResult = DialogResult.OK;
        }

        public int GetCodigoSocio() => this.Socio.soc_Codigo;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool Validar()
        {
            return !this.numCodigo.Validar() && this.EsModificacion
                   ? false : !this.txtNombre.Validar()
                   ? false : !this.txtApellido.Validar()
                   ? false : !this.numDni.Validar()
                   ? false : !this.numTelefono.Validar()
                   ? false : !this.txtDomicilio.Validar()
                   ? false : this.txtEmail.Validar();
        }
    }
}