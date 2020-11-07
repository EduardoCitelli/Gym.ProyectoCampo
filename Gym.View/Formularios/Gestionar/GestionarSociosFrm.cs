namespace Gym.View
{
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

            this.ArmarLista();
        }

        private void ArmarLista()
        {
            this.source = this.SociosController.Listar().ToList();

            this.grd.DataSource = null;
            this.grd.DataSource = this.source;

            this.InicializarColumnas();
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

            if (result == DialogResult.OK) this.ArmarLista();
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
                }
                catch (Exception ex)
                {
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
                this.ArmarLista();
        }

        private void btnActualizar_Click(object sender, EventArgs e) => this.ArmarLista();

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e) => this.Filtrar();

        private void Filtrar()
        {
            this.grd.DataSource = null;
            this.grd.DataSource = this.source.Where(x => x.soc_Nombre.ToLower().Contains(this.txtFiltroNombre.Text.ToLower())).ToList();

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

            var frm = new ProcesarPagoFrm(objeto);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
                this.ArmarLista();
        }

        private void btnVerificarVenc_Click(object sender, EventArgs e)
        {
            var verificado = this.SociosController.VerificarMembresias();

            if (verificado)
                MessageBox.Show("Proceso Realizado Correctamente", "Verificar Vencimientos", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
