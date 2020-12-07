namespace Gym.Auditoria
{
    using Gym.Datos;
    using Gym.Domain;
    using System;
    
    public class LogService
    {
        private int usuId { get; set; }

        private string nombreUsuario { get; set; }

        private string PC { get; set; }

        private DateTime Fecha { get; set; }

        private static LogService Instancia;

        private LogService(int idUsuario, string nombreUsuario)
        {
            this.usuId = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.PC = GetNombrePc();
            this.Fecha = DateTime.Now;
        }

        public static LogService InicializarLog(int idUsuario, string nombreUsuario)
        {
            Instancia = new LogService(idUsuario, nombreUsuario);

            return Instancia;
        }

        public static LogService GetInstancia() => Instancia;

        public void LogSinFormulario(Eventos evento, string observaciones) => this.Log(evento, observaciones, string.Empty);

        public void Log(Eventos evento, string observaciones, string nombreFormulario)
        {
            var nombreEvento = GetNombreEvento(evento);

            this.Log(nombreEvento, observaciones, nombreFormulario);
        }

        public void Log(string nombreEvento, string observaciones, string nombreFormulario)
        {
            var log = new Log()
            {
                log_usu_Id = this.usuId,
                log_Evento = nombreEvento,
                log_Fecha = this.Fecha,
                log_NombreFormulario = nombreFormulario,
                log_NombreUsuario = this.nombreUsuario,
                log_Observaciones = observaciones,
                log_PC = this.PC
            };

            var uow = new UnitOfWork();

            var repository = uow.GetRepository<Log>();

            repository.Add(log);

            uow.Save();

            uow.Dispose();
        }

        private static string GetNombreEvento(Eventos evento)
        {
            switch (evento)
            {
                case Eventos.LoginExitoso:
                    return "Login Exitoso";
                case Eventos.LoginFallido:
                    return "Login Fallido";
                case Eventos.EliminacionExitosa:
                    return "Eliminación Exitosa";
                case Eventos.EliminacionFallida:
                    return "Eliminación Fallida";
                case Eventos.GuardadoExitoso:
                    return "Guardado Exitoso";
                case Eventos.GuardadoFallido:
                    return "Guardado Fallido";
                case Eventos.BackupExitoso:
                    return "Backup Exitoso";
                case Eventos.BackupFallido:
                    return "Backup Fallido";
                default:
                    return evento.ToString();
            }
        }

        private static string GetNombrePc() => string.Format("{0}\\{1}", Environment.UserDomainName, Environment.UserName);
    }
}
