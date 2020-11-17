namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class ClasesSociosFrm : FormABMBase
    {
        private List<Clases_Socios> source;
        private readonly Clases_SociosController controller;
        private readonly Socios socio;

        public ClasesSociosFrm(Socios socio)
        {
            this.InitializeComponent();

            this.source = new List<Clases_Socios>();
            this.controller = new Clases_SociosController();
            this.socio = socio;

            this.lblTitulo.Text = $"Clases de Socio {socio.soc_Nombre} {socio.soc_Apellido}";
            this.ArmarLista();
        }

        private void ArmarLista()
        {
            this.source = this.controller.ListarPorSocio(this.socio.soc_Codigo).ToList();

            this.grdClasesSocios.DataSource = null;
            this.grdClasesSocios.DataSource = this.source;

            this.InicializarColumnas();
        }

        private void InicializarColumnas()
        {
            foreach (var col in this.grdClasesSocios.Columns.Cast<DataGridViewColumn>())
            {
                switch (col.Name)
                {
                    case nameof(Clases_Socios.NombreClase):
                        col.HeaderText = @"Clase";
                        col.Width = 250;
                        col.DisplayIndex = 0;
                        break;

                    case nameof(Clases_Socios.FechaClase):
                        col.HeaderText = @"Fecha Clase";
                        col.Width = 350;
                        col.DisplayIndex = 1;
                        break;

                    case nameof(Clases_Socios.NombreProfesorTitular):
                        col.HeaderText = @"Profesor";
                        col.Width = 250;
                        col.DisplayIndex = 2;
                        break;

                    case nameof(Clases_Socios.Actividad):
                        col.HeaderText = @"Actividad";
                        col.Width = 250;
                        col.DisplayIndex = 3;
                        break;

                    case nameof(Clases_Socios.Salon):
                        col.HeaderText = @"Salon";
                        col.Width = 250;
                        col.DisplayIndex = 4;
                        break;

                    default:
                        col.Visible = false;
                        break;
                }
            }
        }
    }
}
