namespace Gym.Domain
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    
    public partial class Clases
    {
        [NotMapped]
        public int CantidadAlumnosInscriptos => (this.SociosInscriptos?.Count()).GetValueOrDefault();
    }
}
