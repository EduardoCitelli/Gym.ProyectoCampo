namespace Gym.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class VwAlumnosPorClase
    {
        [Key]
        public int Codigo { get; set; }

        public string Actividad { get; set; }

        public int CantidadDeAlumnos { get; set; }
    }
}