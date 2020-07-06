namespace Gym.Domain
{    
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Users
    {
        [Key]
        public int usu_Id { get; set; }

        public string usu_Nombre { get; set; }

        public string usu_Apellido { get; set; }

        public string usu_LoginName { get; set; }

        public string usu_Password { get; set; }

        public int usu_gus_Id { get; set; }

        public string usu_Email { get; set; }

        [ForeignKey(nameof(usu_gus_Id))]
        public virtual GrupoUsuarios Grupo { get; set; }
    }
}
