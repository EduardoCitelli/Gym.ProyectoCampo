namespace Gym.Domain
{
    using System.ComponentModel.DataAnnotations;
    
    public partial class Actividades
    {
        [Key]
        public int act_Codigo { get; set; }

        public string act_Descripcion { get; set; }

        public int act_MinimoAlumnos { get; set; }
    }
}
