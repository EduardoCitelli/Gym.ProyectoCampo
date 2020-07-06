namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;
    
    public partial class GestionarTiposMembresiaFrm : FormGestionarBase
    {
        private TipoMembresiasController controller;

        private TipoMembresiasController TipoMembresiasController => this.controller ?? (this.controller = new TipoMembresiasController());

        private List<TipoMembresias> source = new List<TipoMembresias>();

        public GestionarTiposMembresiaFrm()
        {
            this.InitializeComponent();
            this.ArmarLista();
        }

        private void ArmarLista()
        {
            this.source = this.TipoMembresiasController.Listar().ToList();

            this.grd.DataSource = null;
            this.grd.DataSource = this.source;

            this.InicializarColumnas();
        }

        private void InicializarColumnas()
        {
            foreach(var col in this.grd.Columns.Cast<DataGridViewColumn>())
            {
                switch (col.HeaderText)
                {
                    case nameof(TipoMembresias.tmm_Descripcion):
                        col.HeaderText = @"Descripción";
                        col.Width = 200;
                        col.DisplayIndex = 1;
                        break;

                    case nameof(TipoMembresias.tmm_EsMensual):
                        col.HeaderText = @"Es Mensual";
                        col.Width = 70;
                        col.DisplayIndex = 2;
                        break;

                    case nameof(TipoMembresias.tmm_CantidadMeses):
                        col.HeaderText = @"Meses de Duración";
                        col.Width = 150;
                        col.DisplayIndex = 3;
                        break;

                    case nameof(TipoMembresias.tmm_CantidadClases):
                        col.HeaderText = @"Cantidad de Clases";
                        col.Width = 150;
                        col.DisplayIndex = 4;
                        break;

                    default:
                        col.Visible = false;
                        break;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new TipoMembresiasFrm(this.TipoMembresiasController, false, null);

            var resultado = frm.ShowDialog();

            if (resultado == DialogResult.OK)
                this.ArmarLista();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.NoSelecciono())
            {
                MessageBox.Show("Debe Seleccionar un elemento de la grilla", "Gestion Tipo Membresias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = (int)this.grd.CurrentRow.Cells[nameof(TipoMembresias.tmm_Id)].Value;

            var descripcion = this.grd.CurrentRow.Cells[nameof(TipoMembresias.tmm_Descripcion)].Value.ToString();

            var consulta = MessageBox.Show(@"Está seguro de que desea eliminar el Tipo de Membresía " + descripcion + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (consulta == DialogResult.Yes)
            {
                try
                {
                    this.TipoMembresiasController.EliminarTipoMembresia(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.ArmarLista();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.NoSelecciono())
            {
                MessageBox.Show("Debe Seleccionar un elemento de la grilla", "Gestion Tipo Membresias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = (int)this.grd.CurrentRow.Cells[nameof(TipoMembresias.tmm_Id)].Value;

            var tipo = this.TipoMembresiasController.ObtenerTipoMembresia(id);

            var frm = new TipoMembresiasFrm(this.TipoMembresiasController, true, tipo);
            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
                this.ArmarLista();
        }

        private void btnActualizar_Click(object sender, EventArgs e) => this.ArmarLista();

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            this.grd.DataSource = null;
            this.grd.DataSource = this.source.Where(x => x.tmm_Descripcion.Contains(this.txtFiltroNombre.Text)).ToList();

            this.InicializarColumnas();
        }
    }
}
