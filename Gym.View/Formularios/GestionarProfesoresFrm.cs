namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class GestionarProfesoresFrm : FormGestionarBase
    {
        private readonly ProfesoresController ProfesoresCotroller;
        private List<Profesores> source;

        public GestionarProfesoresFrm()
        {
            this.InitializeComponent();

            this.ProfesoresCotroller = new ProfesoresController();

            this.ArmarLista();
        }

        private void ArmarLista()
        {
            this.source = this.ProfesoresCotroller.Listar().ToList();

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
                    case nameof(Profesores.pro_Codigo):
                        col.HeaderText = @"Código";
                        col.Width = 150;
                        col.DisplayIndex = 0;
                        break;

                    case nameof(Profesores.pro_Nombre):
                        col.HeaderText = @"Nombre";
                        col.Width = 200;
                        col.DisplayIndex = 1;
                        break;

                    case nameof(Profesores.pro_Apellido):
                        col.HeaderText = @"Apellido";
                        col.Width = 200;
                        col.DisplayIndex = 2;
                        break;

                    case nameof(Profesores.pro_Dni):
                        col.HeaderText = @"DNI";
                        col.Width = 150;
                        col.DisplayIndex = 3;
                        break;

                    case nameof(Profesores.pro_Telefono):
                        col.HeaderText = @"Telefono";
                        col.Width = 150;
                        col.DisplayIndex = 4;
                        break;

                    case nameof(Profesores.pro_Direccion):
                        col.HeaderText = @"Dirección";
                        col.Width = 250;
                        col.DisplayIndex = 5;
                        break;

                    case nameof(Profesores.pro_Mail):
                        col.HeaderText = @"E-Mail";
                        col.Width = 250;
                        col.DisplayIndex = 6;
                        break;

                    case nameof(Profesores.pro_FechaNacimiento):
                        col.HeaderText = @"F. Nacimiento";
                        col.Width = 250;
                        col.DefaultCellStyle.Format = "dd/MM/yyyy";
                        col.DisplayIndex = 7;
                        break;

                    case nameof(Profesores.pro_Sueldo):
                        col.HeaderText = @"Sueldo";
                        col.Width = 150;
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        col.DisplayIndex = 8;
                        break;

                    default:
                        col.Visible = false;
                        break;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new ProfesorFrm(this.ProfesoresCotroller, null, false);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
                this.ArmarLista();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!this.ValidarEliminar()) return;

            var codigo = this.ObtenerCodigo(nameof(Profesores.pro_Codigo));

            var nombre = this.ObtenerDescripcion(nameof(Profesores.pro_Nombre));

            var result = MessageBox.Show("Desea Eliminar al Profesor " + nombre + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    this.ProfesoresCotroller.Eliminar(codigo);
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

            var codigo = this.ObtenerCodigo(nameof(Profesores.pro_Codigo));

            var objeto = this.ProfesoresCotroller.Obtener(codigo);

            var frm = new ProfesorFrm(this.ProfesoresCotroller, objeto, true);

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
            this.grd.DataSource = this.source.Where(x => x.pro_Nombre.Contains(this.txtFiltroNombre.Text)).ToList();

            this.InicializarColumnas();
        }
    }
}
