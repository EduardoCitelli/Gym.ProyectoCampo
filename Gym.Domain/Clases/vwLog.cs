namespace Gym.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class vwLog
    {
        [Key]
        public int Id { get; set; }

        public string Usuario { get; set; }

        public string PC { get; set; }

        public string Evento { get; set; }

        public DateTime Fecha { get; set; }

        public string Observaciones { get; set; }
    }
}