namespace Gym.MVC.Models
{
    using Gym.Domain;
    using System;
    
    public class LogModel
    {
        public LogModel(vwLog log)
        {
            this.Id = log.Id;

            this.Usuario = log.Usuario;

            this.PC = log.PC;

            this.Evento = log.Evento;

            this.Fecha = log.Fecha;

            this.Observaciones = log.Observaciones;
        }

        public int Id { get; set; }

        public string Usuario { get; set; }

        public string PC { get; set; }

        public string Evento { get; set; }

        public DateTime Fecha { get; set; }

        public string Observaciones { get; set; }
    }
}