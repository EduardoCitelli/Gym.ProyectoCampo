namespace Gym.View
{
    using Gym.Auditoria;
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class GestionarSociosFrm : FormGestionarBase
    {
        private readonly SociosController SociosController;
        private List<Socios> source;

        public GestionarSociosFrm()
        {
            this.InitializeComponent();

            this.SociosController = new SociosController();
            this.numCodigoSocio.Limpiar();

            this.ArmarLista();
        }

        private void ArmarLista()
        {
            this.source = this.SociosController.Listar().ToList();

            this.grd.DataSource = null;
            this.grd.DataSource = this.source;

            this.InicializarColumnas();
            this.Filtrar();
        }

        private void InicializarColumnas()
        {
            foreach (var col in this.grd.Columns.Cast<DataGridViewColumn>())
            {
                switch (col.Name)
                {
                    case nameof(Socios.soc_Codigo):
                        col.HeaderText = @"Código";
                        col.Width = 150;
                        col.DisplayIndex = 0;
                        break;

                    case nameof(Socios.soc_Nombre):
                        col.HeaderText = @"Nombre";
                        col.Width = 200;
                        col.DisplayIndex = 1;
                        break;

                    case nameof(Socios.soc_Apellido):
                        col.HeaderText = @"Apellido";
                        col.Width = 200;
                        col.DisplayIndex = 2;
                        break;

                    case nameof(Socios.soc_Dni):
                        col.HeaderText = @"DNI";
                        col.Width = 150;
                        col.DisplayIndex = 3;
                        break;

                    case nameof(Socios.soc_Domicilio):
                        col.HeaderText = @"Domicilio";
                        col.Width = 200;
                        col.DisplayIndex = 4;
                        break;

                    case nameof(Socios.soc_Telefono):
                        col.HeaderText = @"Telefono";
                        col.Width = 150;
                        col.DisplayIndex = 5;
                        break;

                    case nameof(Socios.soc_Mail):
                        col.HeaderText = @"E-Mail";
                        col.Width = 220;
                        col.DisplayIndex = 6;
                        break;

                    case nameof(Socios.soc_FechaNacimiento):
                        col.HeaderText = @"Fec. Nacimiento";
                        col.Width = 200;
                        col.DisplayIndex = 7;
                        break;

                    case nameof(Socios.soc_CantidadClasesDisponibles):
                        col.HeaderText = @"Clases Disponibles";
                        col.Width = 80;
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        col.DisplayIndex = 8;
                        break;

                    case nameof(Socios.Membresia.mem_Descripcion):
                        col.HeaderText = @"Membresía";
                        col.Width = 200;
                        col.DisplayIndex = 9;
                        break;

                    default:
                        col.Visible = false;
                        break;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new SocioFrm(this.SociosController, null, false);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK) 
            {
                var log = LogService.GetInstancia();
                log.Log(Eventos.GuardadoExitoso, string.Empty, frm.Name);

                var pregunta = MessageBox.Show("¿Desea Realizar un Pago?", "Nuevo Socio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (pregunta == DialogResult.Yes)
                {
                    var codigoSocio = frm.GetCodigoSocio();
                    var socio = this.SociosController.ObtenerCompleto(codigoSocio);

                    var frmPago = new ProcesarPagoFrm(socio);

                    var resultPago = frmPago.ShowDialog();

                    if (resultPago == DialogResult.OK)
                    {                        
                        log.Log(Eventos.GuardadoExitoso, "Pago Generado", frm.Name);

                        this.ArmarLista();
                    }                        
                }
                else
                    this.ArmarLista();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!this.ValidarEliminar()) return;

            var codigo = this.ObtenerCodigo(nameof(Socios.soc_Codigo));

            var nombre = this.ObtenerDescripcion(nameof(Socios.soc_Nombre));

            var result = MessageBox.Show("Está seguro que desea Eliminar al Usuario " + nombre + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    this.SociosController.Eliminar(codigo);

                    this.log.Log(Eventos.EliminacionExitosa, string.Empty, this.Name);
                }
                catch (Exception ex)
                {
                    this.log.Log(Eventos.EliminacionFallida, ex.Message, this.Name);

                    MessageBox.Show(ex.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.ArmarLista();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!this.ValidarModificar()) return;

            var codigo = this.ObtenerCodigo(nameof(Socios.soc_Codigo));

            var objeto = this.SociosController.Obtener(codigo);

            var frm = new SocioFrm(this.SociosController, objeto, true);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.log.Log(Eventos.GuardadoExitoso, "Modifiación", frm.Name);
                this.ArmarLista();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e) => this.ArmarLista();

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e) => this.Filtrar();

        private void Filtrar()
        {
            this.grd.DataSource = null;

            var lista = this.source;

            if (!string.IsNullOrEmpty(this.txtFiltroNombre.Text))
                lista = lista.Where(x => x.soc_Nombre.ToLower().Contains(this.txtFiltroNombre.Text.ToLower())).ToList();

            if (this.numCodigoSocio.HasValue())
                lista = lista.Where(x => x.soc_Codigo.ToString().Contains(this.numCodigoSocio.GetValor().ToString())).ToList();

            if (this.chkActivos.GetValor())
                lista = lista.Where(x => x.soc_Activo).ToList();

            this.grd.DataSource = lista;

            this.InicializarColumnas();
        }

        private void btnVerClases_Click(object sender, EventArgs e)
        {
            if (!this.ValidarSeleccion()) return;

            var codigo = this.ObtenerCodigo(nameof(Socios.soc_Codigo));

            var objeto = this.SociosController.ObtenerCompleto(codigo);

            var frm = new ClasesSociosFrm(objeto);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
                this.ArmarLista();
        }

        private void btnProcesarPago_Click(object sender, EventArgs e)
        {
            if (!this.ValidarModificar()) return;

            var codigo = this.ObtenerCodigo(nameof(Socios.soc_Codigo));

            var objeto = this.SociosController.ObtenerCompleto(codigo);

            if (!this.ConsultarMembresia(objeto))
                return;

            var frm = new ProcesarPagoFrm(objeto);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.log.Log(Eventos.GuardadoExitoso, "Procesar Pago", frm.Name);
                this.ArmarLista();
            }                
        }

        private bool ConsultarMembresia(Socios socio) =>  this.VerificarMembresiaExistente(socio);

        private bool VerificarMembresiaExistente(Socios socio)
        {
            if (socio.VerificarMembresia())
            {
                var result = MessageBox.Show($"El socio {socio.soc_Nombre} ya tiene una membresía vigente{Environment.NewLine} Desea realizar el pago de todas formas?", "Procesar Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                return result == DialogResult.Yes;
            }

            return true;
        }

        private void btnVerificarVenc_Click(object sender, EventArgs e)
        {
            var verificado = this.SociosController.VerificarMembresias();

            if (verificado)
            {
                this.log.Log("Verificación de Membresías Exitoso", "", this.Name);

                MessageBox.Show("Proceso Realizado Correctamente", "Verificar Vencimientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }               

            this.ArmarLista();
        }

        private bool ValidarSeleccion()
        {
            if (this.NoSelecciono())
            {
                var solucion = "Debe Seleccionar un elemento de la grilla para Ver sus Clases";
                var caption = "Ver Clases";
                MessageBox.Show(solucion, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void chkActivos_ValueChanged(object sender, EventArgs e) => this.Filtrar();
    }
}
