namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Windows.Forms;

    public partial class ActividadFrm : FormABMBase
    {
        private ActividadesController controller;
        private Actividades Actividad;
        private bool EsModificacion;

        public ActividadFrm(ActividadesController controller, bool esModificacion, Actividades actividad)
        {
            this.InitializeComponent();

            this.controller = controller;

            this.EsModificacion = esModificacion;

            if (esModificacion) this.InicializarModificacion(actividad);
        }

        private void InicializarModificacion(Actividades actividad)
        {
            this.lblTitulo.Text = "Modificar Actividad";

            this.Actividad = actividad;
            
            this.txtDescripcion.SetValor(actividad.act_Descripcion);

            this.numCodigo.SetValor(actividad.act_Codigo);
            this.numCodigo.Habilitado = false;

            this.numMinimo.SetValor(actividad.act_MinimoAlumnos);
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (!this.Validar()) return;

            if (this.EsModificacion)
            {
                this.Actividad.act_Descripcion = this.txtDescripcion.GetValor();
                this.Actividad.act_MinimoAlumnos = this.numMinimo.GetValor();
            }
            else
            {
                this.Actividad = new Actividades()
                {
                    act_Codigo = this.numCodigo.GetValor(),
                    act_Descripcion = this.txtDescripcion.GetValor(),
                    act_MinimoAlumnos = this.numMinimo.GetValor()
                };
            }

            try
            {
                this.controller.Guardar(this.Actividad, this.EsModificacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private bool Validar()
        {
            return !this.numCodigo.Validar() && !this.EsModificacion
                   ? false : !this.txtDescripcion.Validar()
                   ? false : this.numMinimo.Validar();
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
