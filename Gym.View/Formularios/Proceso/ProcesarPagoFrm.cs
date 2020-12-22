namespace Gym.View
{
    using Gym.Auditoria;
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class ProcesarPagoFrm : FormABMBase
    {
        private readonly SociosController controller;
        private readonly Socios socio;

        public ProcesarPagoFrm(Socios socio)
        {
            this.InitializeComponent();
            this.socio = socio;
            this.controller = new SociosController();

            this.ArmarTitulos();

            this.RefrescarCombos();

            this.ArmarGrilla();

            
        }

        

        private void ArmarTitulos()
        {
            this.lblTitulo.Text = "Procesar Pago";

            this.lblSocio.Titulo = $"{this.socio.soc_Apellido}, {this.socio.soc_Nombre} - {this.socio.soc_Codigo}";

            this.lblEmail.Titulo = $"Email: {this.socio.soc_Mail}";

            this.lblDomicilio.Titulo = $"Domicilio: {this.socio.soc_Domicilio}";

            this.btnGuardar.Text = "Procesar";
            this.btnSalir.Text = "Cancelar";
        }

        private void RefrescarCombos()
        {
            this.cboMembresias.Refrescar();
            this.cboActividad.Refrescar();
            this.cboFormaPago.Refrescar();
        }

        private void ArmarGrilla()
        {
            this.grdMembresiasSocios.DataSource = null;
            this.grdMembresiasSocios.DataSource = this.socio.HistoricoMembresias;

            this.InicializarColumnas();
        }

        private void InicializarColumnas()
        {
            foreach (var col in this.grdMembresiasSocios.Columns.Cast<DataGridViewColumn>())
            {
                switch (col.Name)
                {
                    case nameof(Socios_Membresias.NombreSocio):
                        col.HeaderText = @"Socio";
                        col.Width = 250;
                        col.DisplayIndex = 0;
                        break;

                    case nameof(Socios_Membresias.DescripcionMembresia):
                        col.HeaderText = @"Membresía";
                        col.Width = 300;
                        col.DisplayIndex = 1;
                        break;

                    case nameof(Socios_Membresias.sms_Precio):
                        col.HeaderText = @"Precio Pagado";
                        col.Width = 200;
                        col.DisplayIndex = 2;
                        break;

                    case nameof(Socios_Membresias.Periodo):
                        col.HeaderText = @"Periodo";
                        col.Width = 350;
                        col.DisplayIndex = 3;
                        break;

                    default:
                        col.Visible = false;
                        break;
                }
            }
        }

        private void cboMembresias_ValueChanged(object sender, System.EventArgs e)
        {
            var membresia = this.cboMembresias.GetValor();

            this.lblPrecio.Titulo = $"$ {membresia.mem_Precio}";

            this.cboActividad.Visible = !membresia.mem_EsPremium;
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            var result = MessageBox.Show("Está seguro de realizar el pago?", "Procesar Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            var membresia = this.cboMembresias.GetValor();

            try
            {
                var resultado = membresia.mem_EsPremium ?
                            this.controller.GenerarPagoPremium(this.socio, membresia, this.cboFormaPago.GetValor()) :
                            this.controller.GenerarPagoComun(this.socio, membresia, this.cboFormaPago.GetValor(), this.cboActividad.GetValor());            

                var navegable = new NavegableFrm();
    
                navegable.Navigate(resultado);

                navegable.ShowDialog();
            }
            catch (Exception ex)
            {
                this.log.Log(Eventos.GuardadoFallido, ex.Message, this.Name);
                MessageBox.Show(ex.Message, "Procesar Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.DialogResult = DialogResult.OK;
        }        
    }
}
