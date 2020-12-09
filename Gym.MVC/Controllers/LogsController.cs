namespace Gym.MVC.Controllers
{
    using Gym.Controladora;
    using Gym.MVC.Models;
    using System.Linq;
    using System.Web.Mvc;

    public class LogsController : Controller
    {
        private readonly VwLogsController controladora = new VwLogsController();

        public ActionResult Index()
        {
            var lista = this.controladora.ListarLogs();

            var model = lista.Select(x => new LogModel(x));

            return this.View(model);
        }
    }
}