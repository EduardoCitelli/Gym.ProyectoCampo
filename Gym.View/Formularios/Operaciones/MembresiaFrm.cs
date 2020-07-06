namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Windows.Forms;

    public partial class MembresiaFrm : FormABMBase
    {
        private Membresias Membresia;
        private readonly MembresiasController Controller;
        private readonly bool EsModificacion;

        public MembresiaFrm(MembresiasController controller, bool esModificacion, Membresias membresia)
        {
            this.InitializeComponent();
            this.Controller = controller;
            this.EsModificacion = esModificacion;
            this.cboTipoMembresia.Refrescar();

            if (this.EsModificacion) this.InicializarModificacion(membresia);
        }

        private void InicializarModificacion(Membresias membresia)
        {
            this.lblTitulo.Text = "Modificar Membresía";

            this.Membresia = membresia;

            this.numCodigo.SetValor(membresia.mem_Codigo);
            this.numCodigo.Habilitado = false;

            this.txtDescripcion.SetValor(membresia.mem_Descripcion);

            this.numPrecio.SetValor(membresia.mem_Precio);

            this.chkPremium.SetValor(membresia.mem_EsPremium);

            this.cboTipoMembresia.SetValor(membresia.mem_tmm_Id);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.Validar()) return;

            if (this.EsModificacion)
            {
                this.Membresia.mem_Descripcion = this.txtDescripcion.GetValor();
                this.Membresia.mem_EsPremium = this.chkPremium.GetValor();
                this.Membresia.mem_Precio = this.numPrecio.GetValor();                
                this.Membresia.mem_tmm_Id = this.cboTipoMembresia.GetValor().tmm_Id;                
            }
            else
            {
                this.Membresia = new Membresias()
                {
                    mem_Codigo = this.numCodigo.GetValor(),
                    mem_Descripcion = this.txtDescripcion.GetValor(),
                    mem_EsPremium = this.chkPremium.GetValor(),
                    mem_Precio = this.numPrecio.GetValor(),                    
                    mem_tmm_Id = this.cboTipoMembresia.GetValor().tmm_Id
                };
            }

            try
            {
                this.Controller.Guardar(this.Membresia, this.EsModificacion);
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
            return !this.txtDescripcion.Validar()
                ? false : !this.EsModificacion && !this.numCodigo.Validar()
                ? false : !this.numPrecio.Validar()
                ? false : this.txtDescripcion.Validar();
        }
    }
}
