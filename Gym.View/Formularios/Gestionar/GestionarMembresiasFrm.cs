namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class GestionarMembresiasFrm : FormGestionarBase
    {
        private MembresiasController controller;

        private MembresiasController ControllerMembresias => this.controller ?? (this.controller = new MembresiasController());

        private List<Membresias> source;

        public GestionarMembresiasFrm()
        {
            this.InitializeComponent();
            this.ArmarLista();
        }

        private void ArmarLista()
        {
            this.source = this.ControllerMembresias.Listar().ToList();

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
                    case nameof(Membresias.mem_Codigo):
                        col.HeaderText = @"Código";
                        col.Width = 180;
                        col.DisplayIndex = 1;
                        break;

                    case nameof(Membresias.mem_Descripcion):
                        col.HeaderText = @"Descripción";
                        col.Width = 200;
                        col.DisplayIndex = 2;
                        break;

                    case nameof(Membresias.mem_EsPremium):
                        col.HeaderText = @"Premium";
                        col.Width = 80;
                        col.DisplayIndex = 3;
                        break;

                    case nameof(Membresias.mem_Precio):
                        col.HeaderText = @"Precio";
                        col.Width = 80;
                        col.DisplayIndex = 4;
                        break;

                    case nameof(Membresias.Tipo):
                        col.HeaderText = @"Tipo";
                        col.Width = 200;
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
            var frm = new MembresiaFrm(this.ControllerMembresias, false, null);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
                this.ArmarLista();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.NoSelecciono())
            {
                MessageBox.Show("Debe seleccionar un elemento de la grilla", "MEMBRESIAS");
                return;
            }

            var codigo = Convert.ToInt32(this.grd.CurrentRow.Cells[nameof(Membresias.mem_Codigo)].Value);
            var nombre = this.grd.CurrentRow.Cells[nameof(Membresias.mem_Descripcion)].ToString();

            var consulta = MessageBox.Show(@"Está Seguro que desea eliminar la membresía, " + nombre + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (consulta == DialogResult.Yes)
            {
                try
                {
                    this.controller.Eliminar(codigo);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                this.ArmarLista();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.NoSelecciono())
            {
                MessageBox.Show("Debe seleccionar un elemento de la grilla", "MEMBRESIAS");
                return;
            }

            var codigo = Convert.ToInt32(this.grd.CurrentRow.Cells[nameof(Membresias.mem_Codigo)].Value);
            var membresia = this.ControllerMembresias.Obtener(codigo);

            var frm = new MembresiaFrm(this.ControllerMembresias, true, membresia);
            var resultado = frm.ShowDialog();

            if (resultado == DialogResult.OK)
                this.ArmarLista();
        }

        private void btnActualizar_Click(object sender, EventArgs e) => this.ArmarLista();

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e) => this.Filtrar();

        private void Filtrar()
        {
            this.grd.DataSource = null;
            this.grd.DataSource = this.source.Where(x => x.mem_Descripcion.Contains(this.txtFiltroNombre.Text)).ToList();

            this.InicializarColumnas();
        }
    }
}
