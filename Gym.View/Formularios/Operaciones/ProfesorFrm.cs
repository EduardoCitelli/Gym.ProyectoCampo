namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Windows.Forms;

    public partial class ProfesorFrm : FormABMBase
    {
        private readonly ProfesoresController profesoresCotroller;
        private readonly bool EsModificacion;
        private Profesores Profesor;

        public ProfesorFrm(ProfesoresController controller, Profesores profesor, bool esModificacion)
        {
            this.InitializeComponent();

            this.profesoresCotroller = controller;
            this.EsModificacion = esModificacion;
            
            if (this.EsModificacion) this.InicializarModificacion(profesor);
        }

        private void InicializarModificacion(Profesores profesor)
        {
            this.lblTitulo.Text = "Modificar Profesor";

            this.Profesor = profesor;

            this.numCodigo.SetValor(profesor.pro_Codigo);
            this.numCodigo.Habilitado = false;

            this.txtNombre.SetValor(profesor.pro_Nombre);

            this.txtApellido.SetValor(profesor.pro_Apellido);

            this.numDNI.SetValor(profesor.pro_Dni);

            this.dtNacimiento.SetValor(profesor.pro_FechaNacimiento);

            this.numTelefono.SetValor((int)profesor.pro_Telefono);

            this.txtDireccion.SetValor(profesor.pro_Direccion);

            this.txtEmail.SetValor(profesor.pro_Mail);

            this.numSueldo.SetValor(profesor.pro_Sueldo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.Validar()) return;

            if (this.EsModificacion)
            {
                this.Profesor.pro_Nombre = this.txtNombre.GetValor();
                this.Profesor.pro_Apellido = this.txtApellido.GetValor();
                this.Profesor.pro_Direccion = this.txtDireccion.GetValor();
                this.Profesor.pro_Mail = this.txtEmail.GetValor();
                this.Profesor.pro_Dni = this.numDNI.GetValor();
                this.Profesor.pro_Telefono = this.numTelefono.GetValor();
                this.Profesor.pro_Sueldo = this.numSueldo.GetValor();
                this.Profesor.pro_FechaNacimiento = this.dtNacimiento.GetValor().Value;
            }
            else
            {
                this.Profesor = new Profesores()
                {
                    pro_Codigo = this.numCodigo.GetValor(),
                    pro_Nombre = this.txtNombre.GetValor(),
                    pro_Apellido = this.txtApellido.GetValor(),
                    pro_Direccion = this.txtDireccion.GetValor(),
                    pro_Dni = this.numDNI.GetValor(),
                    pro_FechaNacimiento = this.dtNacimiento.GetValor().Value,
                    pro_Mail = this.txtEmail.GetValor(),
                    pro_Sueldo = this.numSueldo.GetValor(),
                    pro_Telefono = this.numTelefono.GetValor()
                };
            }

            try
            {
                this.profesoresCotroller.Guardar(this.Profesor, this.EsModificacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool Validar()
        {
            return !this.numCodigo.Validar() && !this.EsModificacion
                   ? false : !this.txtNombre.Validar()
                   ? false : !this.txtApellido.Validar()
                   ? false : !this.numDNI.Validar()
                   ? false : !this.numTelefono.Validar()
                   ? false : !this.txtDireccion.Validar()
                   ? false : !this.txtEmail.Validar()
                   ? false : this.numSueldo.Validar();
        }
    }
}
