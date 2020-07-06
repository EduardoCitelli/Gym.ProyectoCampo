namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class GestionarClasesFrm : FormGestionarBase
    {
        private readonly ClasesController clasesController;
        private List<Clases> source;

        public GestionarClasesFrm()
        {
            this.InitializeComponent();

            this.clasesController = new ClasesController();

            this.ArmarLista();
        }

        private void ArmarLista()
        {
            this.source = this.clasesController.ListarCompleto().ToList();

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
                    case nameof(Clases.cls_Descripcion):
                        col.HeaderText = @"Clase";
                        col.Width = 200;
                        col.DisplayIndex = 0;
                        break;

                    case nameof(Clases.cls_FechaInicio):
                        col.HeaderText = @"Inicio";
                        col.Width = 250;
                        col.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                        col.DisplayIndex = 1;
                        break;

                    case nameof(Clases.cls_FechaFinal):
                        col.HeaderText = @"Final";
                        col.Width = 150;
                        col.DefaultCellStyle.Format = "HH:mm";
                        col.DisplayIndex = 2;
                        break;

                    case nameof(Clases.Titular):
                        col.HeaderText = @"Prof. Titular";
                        col.Width = 200;
                        col.DisplayIndex = 3;
                        break;

                    case nameof(Clases.Auxiliar):
                        col.HeaderText = @"Prof. Auxiliar";
                        col.Width = 200;
                        col.DisplayIndex = 4;
                        break;

                    case nameof(Clases.Actividad):
                        col.HeaderText = @"Actividad";
                        col.Width = 200;
                        col.DisplayIndex = 5;
                        break;

                    case nameof(Clases.Salon):
                        col.HeaderText = @"Salon";
                        col.Width = 200;
                        col.DisplayIndex = 6;
                        break;

                    case nameof(Clases.CantidadAlumnosInscriptos):
                        col.HeaderText = @"Cant. Alumnos";
                        col.Width = 80;
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        col.DisplayIndex = 7;
                        break;


                    default:
                        col.Visible = false;
                        break;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new ClaseFrm(this.clasesController, null, false);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK) this.ArmarLista();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!this.ValidarEliminar()) return;

            var codigo = this.ObtenerCodigo(nameof(Clases.cls_Id));

            var descripcion = this.ObtenerDescripcion(nameof(Clases.cls_Descripcion));

            var result = MessageBox.Show("Está Seguro de Eliminar la Clase " + descripcion + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                try
                {
                    this.clasesController.Eliminar(codigo);
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

            var objeto = this.ObtenerClase();

            var frm = new ClaseFrm(this.clasesController, objeto, true);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
                this.ArmarLista();
        }

        private Clases ObtenerClase()
        {
            var codigo = this.ObtenerCodigo(nameof(Clases.cls_Id));

            var objeto = this.clasesController.ObtenerCompleto(codigo);

            return objeto;
        }

        protected override bool ValidarModificar() => !base.ValidarModificar() ? false : this.ValidarClaseDadaDeAlta();

        private bool ValidarClaseDadaDeAlta()
        {
            var objeto = this.ObtenerClase();

            if (objeto.cls_Estado != "P")
            {
                MessageBox.Show("La clase ya está dada de Alta, darla de baja para poder Modificarla", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidarClasePendienteDarAlta()
        {
            var objeto = this.ObtenerClase();

            if (objeto.cls_Estado != "A")
            {
                MessageBox.Show("La Clase no está dada de Alta, No puede Agregar Alumnos", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnActualizar_Click(object sender, EventArgs e) => this.ArmarLista();

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e) => this.Filtrar();

        private void Filtrar()
        {
            this.grd.DataSource = null;
            this.grd.DataSource = this.source.Where(x => x.cls_Descripcion.Contains(this.txtFiltroNombre.Text));

            this.InicializarColumnas();
        }

        private void btnAddAlumno_Click(object sender, EventArgs e)
        {
            if (!base.ValidarModificar()) return;

            if (!this.ValidarClasePendienteDarAlta()) return;

            var objeto = this.ObtenerClase();

            this.AbrirFormularioClasesSocios(objeto);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (!base.ValidarModificar()) return;
            
            var objeto = this.ObtenerClase();

            if (objeto.cls_Estado != "P")
            {
                MessageBox.Show("La clase ya está dada de Alta, usar el boton Agregar/Eliminar Alumnos para Modificar la cantidad", "Alta Clase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.AbrirFormularioClasesSocios(objeto);
        }

        private void AbrirFormularioClasesSocios(Clases objeto)
        {
            var frm = new AltaClasesFrm(objeto);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
                this.ArmarLista();
        }
    }
}
