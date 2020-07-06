namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class GestionarUsuariosFrm : FormGestionarBase
    {
        private UsersController controller;

        private UsersController Controller => this.controller ?? (this.controller = new UsersController());

        private List<Users> source;

        public GestionarUsuariosFrm()
        {
            this.InitializeComponent();

            this.source = new List<Users>();

            this.ArmarLista();
        }

        public void ArmarLista()
        {
            this.source = this.Controller.ListarUsuarios().ToList();

            this.grd.DataSource = null;
            this.grd.DataSource = this.source;

            this.IniciarColumnas();
        }

        private void IniciarColumnas()
        {
            foreach (var col in this.grd.Columns.Cast<DataGridViewColumn>())
            {
                switch (col.HeaderText)
                {                    
                    case nameof(Users.usu_Nombre):
                        col.HeaderText = @"Nombre";
                        col.Width = 180;
                        col.DisplayIndex = 1;
                        break;

                    case nameof(Users.usu_Apellido):
                        col.HeaderText = @"Apellido";
                        col.Width = 180;
                        col.DisplayIndex = 2;
                        break;

                    case nameof(Users.usu_LoginName):
                        col.HeaderText = @"Usuario";
                        col.Width = 180;
                        col.DisplayIndex = 3;
                        break;

                    case nameof(Users.usu_Email):
                        col.HeaderText = @"E-Mail";
                        col.Width = 250;
                        col.DisplayIndex = 4;
                        break;

                    case nameof(Users.Grupo):
                        col.HeaderText = @"Grupo";
                        col.Width = 180;
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
            var frm = new UsuarioFrm(this.Controller, false, null);

            var resultado = frm.ShowDialog();

            if (resultado == DialogResult.OK)
                this.ArmarLista();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.NoSelecciono())
            {
                MessageBox.Show("Debe seleccionar un elemento de la grilla", "USUARIOS");
                return;
            }

            var id = Convert.ToInt32(this.grd.CurrentRow.Cells[nameof(Users.usu_Id)].Value);
            var nombre = this.grd.CurrentRow.Cells[nameof(Users.usu_LoginName)].Value.ToString();

            var consulta = MessageBox.Show(@"Está seguuro que desea eliminar al Usuario " + nombre+ "?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (consulta == DialogResult.Yes)
            {
                try
                {
                    this.Controller.Eliminar(id);
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
                MessageBox.Show("Debe seleccionar un elemento de la grilla", "USUARIOS");
                return;
            }

            var idUsuario = Convert.ToInt32(this.grd.CurrentRow.Cells[nameof(Users.usu_Id)].Value);
            var usuario = this.Controller.Obtener(idUsuario);

            var frm = new UsuarioFrm(this.Controller, true, usuario);
            var resultado = frm.ShowDialog();

            if (resultado == DialogResult.OK)
                this.ArmarLista();
        }

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e) => this.Filtrar();

        private void btnActualizar_Click(object sender, EventArgs e) => this.ArmarLista();

        private void Filtrar()
        {
            this.grd.DataSource = null;

            this.grd.DataSource = this.source.Where(x => x.usu_Nombre.Contains(this.txtFiltroNombre.Text)).ToList();

            this.IniciarColumnas();
        }
    }
}
