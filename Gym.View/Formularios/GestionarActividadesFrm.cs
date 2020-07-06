namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class GestionarActividadesFrm : FormGestionarBase
    {
        private ActividadesController ControllerActividades;
        private List<Actividades> source;
        public GestionarActividadesFrm()
        {
            this.InitializeComponent();

            this.ControllerActividades = new ActividadesController();

            this.ArmarLista();
        }

        private void ArmarLista()
        {
            this.source = this.ControllerActividades.Listar().ToList();

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
                    case nameof(Actividades.act_Codigo):
                        col.HeaderText = @"Código";
                        col.Width = 150;
                        col.DisplayIndex = 0;
                        break;

                    case nameof(Actividades.act_Descripcion):
                        col.HeaderText = @"Actividad";
                        col.Width = 200;
                        col.DisplayIndex = 1;
                        break;

                    case nameof(Actividades.act_MinimoAlumnos):
                        col.HeaderText = @"Minimo Alumnos";
                        col.Width = 80;
                        col.DisplayIndex = 2;
                        break;

                    default:
                        col.Visible = false;
                        break;
                }
            }
        }

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e) => this.Filtrar();

        private void Filtrar()
        {
            this.grd.DataSource = null;
            this.grd.DataSource = this.source.Where(x => x.act_Descripcion.Contains(txtFiltroNombre.Text)).ToList();

            this.InicializarColumnas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new ActividadFrm(this.ControllerActividades, false, null);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
                this.ArmarLista();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.NoSelecciono())
            {
                var solucion = "Debe Seleccionar un elemento de la grilla";

                MessageBox.Show(solucion, "ACTIVIDADES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var codigo = Convert.ToInt32(this.grd.CurrentRow.Cells[nameof(Actividades.act_Codigo)].Value);
            var nombre = this.grd.CurrentRow.Cells[nameof(Actividades.act_Descripcion)].Value.ToString();

            var result = MessageBox.Show("Desea eliminar la Actividad " + nombre + "?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    this.ControllerActividades.Eliminar(codigo);
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
            if (this.NoSelecciono())
            {
                var solucion = "Debe selecconar un elemento de la grilla";
                var caption = "Actividad";
                MessageBox.Show(solucion, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var codigo = Convert.ToInt32(this.grd.CurrentRow.Cells[nameof(Actividades.act_Codigo)].Value);
            var objeto = this.ControllerActividades.Obtener(codigo);

            var frm = new ActividadFrm(this.ControllerActividades, true, objeto);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
                this.ArmarLista();
        }

        private void btnActualizar_Click(object sender, EventArgs e) => this.ArmarLista();

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();
    }
}
