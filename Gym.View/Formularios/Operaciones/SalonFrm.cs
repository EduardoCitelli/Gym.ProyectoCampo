namespace Gym.View
{
    using Gym.Auditoria;
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Windows.Forms;

    public partial class SalonFrm : FormABMBase
    {
        private Salones Salon;
        private readonly bool EsModificacion;
        private readonly SalonesController SalonesController;

        public SalonFrm(SalonesController controller, bool esModificacion, Salones salon)
        {
            this.InitializeComponent();

            this.SalonesController = controller;

            this.EsModificacion = esModificacion;

            if (esModificacion) this.InicializarModificacion(salon);
        }

        private void InicializarModificacion(Salones salon)
        {
            this.lblTitulo.Text = "Modificar Salon";

            this.Salon = salon;

            this.numCodigo.SetValor(this.Salon.sal_Codigo);
            this.numCodigo.Habilitado = false;

            this.txtDescripcion.SetValor(this.Salon.sal_Descripcion);

            this.numTamanio.SetValor(this.Salon.sal_Tamanio);

            this.numPiso.SetValor(this.Salon.sal_Piso);

            this.numNumero.SetValor(this.Salon.sal_Nro);

            this.numCapacidad.SetValor(this.Salon.sal_Capacidad);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.Validar()) return;

            if (this.EsModificacion)
            {
                this.Salon.sal_Descripcion = txtDescripcion.GetValor();
                this.Salon.sal_Capacidad = this.numCapacidad.GetValor();
                this.Salon.sal_Nro = this.numNumero.GetValor();
                this.Salon.sal_Piso = this.numPiso.GetValor();
                this.Salon.sal_Tamanio = this.numTamanio.GetValor();
            }
            else
            {
                this.Salon = new Salones()
                {
                    sal_Codigo = this.numCodigo.GetValor(),
                    sal_Descripcion = this.txtDescripcion.GetValor(),
                    sal_Capacidad = this.numCapacidad.GetValor(),
                    sal_Nro = this.numNumero.GetValor(),
                    sal_Piso = this.numPiso.GetValor(),
                    sal_Tamanio = this.numTamanio.GetValor()
                };
            }

            try
            {
                this.SalonesController.Guardar(this.Salon, this.EsModificacion);
            }
            catch (Exception ex)
            {
                this.log.Log(Eventos.GuardadoFallido, ex.Message, this.Name);
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
                   ? false : !this.txtDescripcion.Validar()
                   ? false : !this.numCapacidad.Validar()
                   ? false : !this.numTamanio.Validar()
                   ? false : !this.numNumero.Validar()
                   ? false : this.numPiso.Validar();                   
        }
    }
}
