namespace Gym.View
{
    using Gym.Auditoria;
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Windows.Forms;

    public partial class TipoMembresiasFrm : FormABMBase
    {
        private TipoMembresias nuevoTipo;
        private TipoMembresiasController ControllerTipoMembresia;
        private readonly bool esModificacion;

        public TipoMembresiasFrm(TipoMembresiasController controller, bool esModificacion, TipoMembresias tipoMembresia)
        {
            this.InitializeComponent();

            this.ControllerTipoMembresia = controller;

            this.esModificacion = esModificacion;

            this.nuevoTipo = tipoMembresia;

            if (this.esModificacion) this.InicializarModificacion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.Validar()) return;

            if (this.esModificacion)
            {
                this.nuevoTipo.tmm_Descripcion = this.txtDescripcion.Text;

                this.nuevoTipo.tmm_EsMensual = this.chkMensual.Checked;

                this.nuevoTipo.tmm_CantidadMeses = Convert.ToInt32(this.numCantMeses.Value);

                if (this.numCantClases.Value != 0)
                    this.nuevoTipo.tmm_CantidadClases = Convert.ToInt32(this.numCantClases.Value);
            }
            else
            {
                this.nuevoTipo = new TipoMembresias()
                {
                    tmm_Descripcion = this.txtDescripcion.Text,
                    tmm_EsMensual = this.chkMensual.Checked,
                    tmm_CantidadMeses = (int)this.numCantMeses.Value
                };

                if (this.numCantClases.Value != 0)
                    this.nuevoTipo.tmm_CantidadClases = (int)this.numCantClases.Value;
            }
            try
            {
                this.ControllerTipoMembresia.GuardarTipoMembresia(this.nuevoTipo, this.esModificacion);
            }
            catch (Exception ex)
            {
                this.log.Log(Eventos.GuardadoFallido, ex.Message, this.Name);
                MessageBox.Show(ex.Message);
                return;
            }            

            this.DialogResult = DialogResult.OK;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void InicializarModificacion()
        {
            this.lblTitulo.Text = "Modificar Tipo Membresía";

            this.txtDescripcion.Text = this.nuevoTipo.tmm_Descripcion;

            this.numCantClases.Value = this.nuevoTipo.tmm_CantidadClases.GetValueOrDefault();

            this.numCantMeses.Value = this.nuevoTipo.tmm_CantidadMeses;

            this.chkMensual.Checked = this.nuevoTipo.tmm_EsMensual;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(this.txtDescripcion.Text))
            {
                MessageBox.Show("Escriba una Descripción", "Tipo Membresías", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
