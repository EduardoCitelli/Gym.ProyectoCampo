namespace Gym.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Log
    {
        [Key]
        public int log_Id { get; set; }

        public int log_usu_Id { get; set; }

        public string log_NombreUsuario { get; set; }

        public string log_PC { get; set; }

        public string log_Evento { get; set; }

        public string log_NombreFormulario { get; set; }

        public DateTime log_Fecha { get; set; }

        public string log_Observaciones { get; set; }
    }
}