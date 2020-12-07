namespace Gym.Test
{
    using Gym.Auditoria;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class LogTests
    {
        [TestMethod]
        public void GuardarLog()
        {
            var service = LogService.InicializarLog(0, "Prueba");
            service.LogSinFormulario(Eventos.GuardadoExitoso, "Prueba");
        }
    }
}