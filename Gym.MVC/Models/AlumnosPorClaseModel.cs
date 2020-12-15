namespace Gym.MVC.Models
{
    using Gym.Domain;

    public class AlumnosPorClaseModel
    {
        public AlumnosPorClaseModel(VwAlumnosPorClase actividad)
        {
            this.Codigo = actividad.Codigo;
            this.Actividad = actividad.Actividad;
            this.CantidadDeAlumnos = actividad.CantidadDeAlumnos;
        }

        public int Codigo { get; set; }

        public string Actividad { get; set; }

        public int CantidadDeAlumnos { get; set; }
    }
}