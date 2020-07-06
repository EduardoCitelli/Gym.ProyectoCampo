namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class GestionarGruposFrm : FormGestionarBase
    {
        private GrupoUsuariosController controller;

        private GrupoUsuariosController Controller => this.controller ?? (this.controller = new GrupoUsuariosController());

        private List<GrupoUsuarios> source = new List<GrupoUsuarios>();

        public GestionarGruposFrm()
        {
            this.InitializeComponent();
            this.ArmarLista();
        }

        private void ArmarLista()
        {
            this.source = this.Controller.Listar().ToList();

            this.grd.DataSource = null;
            this.grd.DataSource = this.source;

            this.InicializarColumnas();
        }

        private void InicializarColumnas()
        {
            foreach (var col in this.grd.Columns.Cast<DataGridViewColumn>())
            {
                switch (col.HeaderText)
                {
                    case nameof(GrupoUsuarios.gus_Descripcion):
                        col.HeaderText = @"Nombre";
                        col.Width = 200;
                        col.DisplayIndex = 1;
                        break;

                    default:
                        col.Visible = false;
                        break;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new GrupoFrm(this.Controller, false, null);

            var resultado = frm.ShowDialog();

            if (resultado == DialogResult.OK)
                this.ArmarLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.NoSelecciono())
            {
                MessageBox.Show("Debe seleccionar un elemento de la grilla", "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var idGrupo = Convert.ToInt32(this.grd.CurrentRow.Cells[nameof(GrupoUsuarios.gus_Id)].Value);

            var grupo = this.Controller.ObtenerGrupo(idGrupo);

            var frm = new GrupoFrm(this.Controller, true, grupo);
            var resultado = frm.ShowDialog();

            if (resultado == DialogResult.OK)
                this.ArmarLista();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.NoSelecciono())
            {
                MessageBox.Show("Debe seleccionar un elemento de la grilla", "GRUPOS");
                return;
            }

            var id = Convert.ToInt32(this.grd.CurrentRow.Cells[nameof(GrupoUsuarios.gus_Id)].Value);

            var nombre = this.grd.CurrentRow.Cells[nameof(GrupoUsuarios.gus_Descripcion)].Value.ToString();

            var consulta = MessageBox.Show(@"Está seguro que desea eliminar el Grupo " + nombre + "?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (consulta == DialogResult.Yes)
            {
                try
                {
                    this.Controller.EliminarGrupo(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Grupo Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.ArmarLista();
            }            
        }

        private void btnActualizar_Click(object sender, EventArgs e) => this.ArmarLista();

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e) => this.Filtrar();

        private void Filtrar()
        {
            this.grd.DataSource = null;

            this.grd.DataSource = this.source.Where(x => x.gus_Descripcion.Contains(this.txtFiltroNombre.Text)).ToList();

            this.InicializarColumnas();
        }        
    }
}
