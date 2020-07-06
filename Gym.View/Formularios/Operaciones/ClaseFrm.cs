namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Windows.Forms;

    public partial class ClaseFrm : FormABMBase
    {
        private readonly ClasesController clasesController;
        private readonly bool esModificacion;
        private Clases Clase;

        public ClaseFrm(ClasesController clasesController, Clases clase, bool esModificacion)
        {
            this.InitializeComponent();

            this.clasesController = clasesController;

            this.esModificacion = esModificacion;

            this.CargarCombos();

            if (esModificacion) this.InicializarModificacion(clase);
        }

        private void CargarCombos()
        {
            this.comboActividad.Refrescar();
            this.comboAuxiliar.Refrescar();
            this.comboTitular.Refrescar();
            this.comboSalon.Refrescar();
        }

        private void InicializarModificacion(Clases clase)
        {
            this.lblTitulo.Text = @"Modificar Clase";

            this.Clase = clase;
            this.EliminarAdicional();

            this.txtDescripcion.SetValor(this.Clase.cls_Descripcion);

            this.dtInicio.SetValor(this.Clase.cls_FechaInicio);

            this.numDuracion.SetValor(this.Clase.cls_FechaFinal.Hour - this.Clase.cls_FechaInicio.Hour);

            this.comboActividad.SetValor(this.Clase.cls_act_Codigo);

            this.comboSalon.SetValor(this.Clase.cls_sal_Codigo);

            this.comboTitular.SetValor(this.Clase.cls_pro_Titular);

            if (this.Clase.cls_pro_Auxiliar.HasValue)
                this.comboAuxiliar.SetValor(this.Clase.cls_pro_Auxiliar.Value);
        }

        private void EliminarAdicional()
        {
            this.Clase.Titular = null;
            this.Clase.Salon = null;
            this.Clase.Auxiliar = null;
            this.Clase.Actividad = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.Validar()) return;

            if (this.esModificacion)
            {
                this.Clase.cls_Descripcion = this.txtDescripcion.GetValor();

                this.Clase.cls_FechaInicio = this.dtInicio.GetValor().Value;

                this.Clase.cls_FechaFinal = this.dtInicio.GetValor().Value.AddHours(this.numDuracion.GetValor());

                this.Clase.cls_act_Codigo = this.comboActividad.GetValor().act_Codigo;

                this.Clase.cls_sal_Codigo = this.comboSalon.GetValor().sal_Codigo;

                this.Clase.cls_pro_Titular = this.comboTitular.GetValor().pro_Codigo;
            }
            else
            {
                this.Clase = new Clases()
                {
                    cls_Descripcion = this.txtDescripcion.GetValor(),
                    cls_FechaInicio = this.dtInicio.GetValor().Value,
                    cls_FechaFinal = this.dtInicio.GetValor().Value.AddHours(this.numDuracion.GetValor()),
                    cls_act_Codigo = this.comboActividad.GetValor().act_Codigo,
                    cls_sal_Codigo = this.comboSalon.GetValor().sal_Codigo,
                    cls_pro_Titular = this.comboTitular.GetValor().pro_Codigo,                    
                    cls_Estado = "P"
                };
            }

            var codigoAuxiliar = this.comboAuxiliar.GetValor().pro_Codigo;
            if (codigoAuxiliar != 0)
                this.Clase.cls_pro_Auxiliar = codigoAuxiliar;

            try
            {
                this.clasesController.Guardar(this.Clase, this.esModificacion);
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

        private bool Validar() => !this.txtDescripcion.Validar() ? false : this.numDuracion.Validar();
    }
}
