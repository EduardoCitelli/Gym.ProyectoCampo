namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class AgregarSociosFrm : FormABMBase
    {
        private readonly Clases_SociosController Clases_SociosController;

        private readonly Clases clase;
        private List<Socios> source;
        private readonly List<Clases_Socios> ListaArmada;

        public AgregarSociosFrm(Clases clase)
        {
            this.InitializeComponent();

            this.Clases_SociosController = new Clases_SociosController();

            this.clase = clase;
            this.ListaArmada = this.Clases_SociosController.ListarPorClase(clase.cls_Id).ToList();
            this.ArmarLista();
        }

        private void ArmarLista()
        {
            this.source = this.Clases_SociosController.ListarSocios().ToList();

            this.AgregarCheck();

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
                    case nameof(Socios.Chk):
                        col.HeaderText = @" ";                        
                        col.Width = 50;
                        col.DisplayIndex = 0;
                        break;

                    case nameof(Socios.soc_Codigo):
                        col.HeaderText = @"Cod. Socio";
                        col.Width = 150;
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        col.ReadOnly = true;
                        col.DisplayIndex = 1;
                        break;

                    case nameof(Socios.soc_Nombre):
                        col.HeaderText = @"Alumno";
                        col.Width = 200;
                        col.ReadOnly = true;
                        col.DisplayIndex = 2;
                        break;

                    default:
                        col.Visible = false;
                        break;
                }
            }
        }

        private void AgregarCheck()
        {
            var listaSocios = this.ListaArmada.Select(x => x.css_soc_Codigo).ToList();

            foreach (var clase in this.source.Where(x => listaSocios.Contains(x.soc_Codigo)))
                clase.Chk = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.Validar()) return;

            var result = MessageBox.Show("Está Seguro que desea dar de alta la Clase?", "Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            this.ListaArmada.Clear();

            foreach (var alumno in this.ObtenerAlumnosAgregados())
            {
                var claseSocio = new Clases_Socios()
                {
                    css_soc_Codigo = alumno,
                    css_cls_Id = this.clase.cls_Id
                };

                this.ListaArmada.Add(claseSocio);                
            }

            try
            {
                this.Clases_SociosController.Guardar(this.ListaArmada, this.clase);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Clase dada de Alta correctamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
        }

        private List<int> ObtenerAlumnosAgregados()
        {
            var idsAlumnos = new List<int>();

            foreach (var row in this.grd.Rows.Cast<DataGridViewRow>().Where(x => (bool)x.Cells[nameof(Socios.Chk)].Value == true))
            {
                idsAlumnos.Add((int)row.Cells[nameof(Socios.soc_Codigo)].Value);
            }

            return idsAlumnos;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool Validar()
        {
            return !this.ValidarMinimo()
                   ? false : !this.ValidarMaximo()
                   ? false : !this.ValidarProfesor()
                   ? false : this.ValidarSalon();
        }

        private bool ValidarMinimo()
        {
            if (this.ObtenerAlumnosAgregados().Count < this.clase.Actividad.act_MinimoAlumnos)
            {
                MessageBox.Show("Debe Agregar mas alumnos para dar de alta la Clase", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidarMaximo()
        {
            if (this.ObtenerAlumnosAgregados().Count > this.clase.Salon.sal_Capacidad)
            {
                MessageBox.Show("Debe Sacar Alumnos ya que supera la capacidad del salon", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidarSalon()
        {
            if (this.Clases_SociosController.SalonOcupado(this.clase))
            {
                MessageBox.Show("El Salon Ya tiene una Clase asignada en ese horario", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidarProfesor()
        {
            if (this.Clases_SociosController.ProfesorOcupado(this.clase))
            {
                MessageBox.Show("El Profesor Ya tiene una Clase asignada en ese horario", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
