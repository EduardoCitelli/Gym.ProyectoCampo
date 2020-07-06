namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class GestionarSalonesFrm : FormGestionarBase
    {
        private SalonesController SalonesController;
        private List<Salones> source;

        public GestionarSalonesFrm()
        {
            this.InitializeComponent();
            this.SalonesController = new SalonesController();

            this.ArmarLista();
        }

        private void ArmarLista()
        {
            this.source = this.SalonesController.Listar().ToList();

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
                    case nameof(Salones.sal_Codigo):
                        col.HeaderText = @"Código";
                        col.Width = 150;
                        col.DisplayIndex = 0;
                        break;

                    case nameof(Salones.sal_Descripcion):
                        col.HeaderText = @"Salon";
                        col.Width = 200;
                        col.DisplayIndex = 1;
                        break;

                    case nameof(Salones.sal_Capacidad):
                        col.HeaderText = @"Capacidad";
                        col.Width = 100;
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        col.DisplayIndex = 2;
                        break;

                    case nameof(Salones.sal_Tamanio):
                        col.HeaderText = @"Tamaño Fisico";
                        col.Width = 150;
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        col.DisplayIndex = 3;
                        break;

                    case nameof(Salones.sal_Nro):
                        col.HeaderText = @"Numero";
                        col.Width = 80;
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        col.DisplayIndex = 4;
                        break;

                    case nameof(Salones.sal_Piso):
                        col.HeaderText = @"Piso";
                        col.Width = 80;
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        col.DisplayIndex = 5;
                        break;

                    default:
                        col.Visible = false;
                        break;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new SalonFrm(this.SalonesController, false, null);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
                this.ArmarLista();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!this.ValidarEliminar()) return;

            var codigo = this.ObtenerCodigo(nameof(Salones.sal_Codigo));
            var nombre = this.ObtenerDescripcion(nameof(Salones.sal_Descripcion));

            var result = MessageBox.Show("Desea Eliminar el salon " + nombre + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    this.SalonesController.Eliminar(codigo);
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

            var codigo = this.ObtenerCodigo(nameof(Salones.sal_Codigo));

            var objeto = this.SalonesController.Obtener(codigo);

            var frm = new SalonFrm(this.SalonesController, true, objeto);

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
            this.grd.DataSource = this.source.Where(x => x.sal_Descripcion.Contains(this.txtFiltroNombre.Text)).ToList();

            this.InicializarColumnas();
        }
    }
}
