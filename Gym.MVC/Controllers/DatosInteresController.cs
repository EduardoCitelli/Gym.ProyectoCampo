namespace Gym.MVC.Controllers
{
    using Gym.Controladora;
    using Gym.MVC.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class DatosInteresController : Controller
    {
        private readonly VwMembresiasActivasController membresiasActivasController;
        private readonly VwAlumnosPorClaseController alumnosPorClaseController;
        private readonly VwIngresosPorMembresiasController ingresosPorMembresiasController;
        private readonly VwFormasPagoController formasPagoController;

        public DatosInteresController()
        {
            this.membresiasActivasController = new VwMembresiasActivasController();
            this.alumnosPorClaseController = new VwAlumnosPorClaseController();
            this.ingresosPorMembresiasController = new VwIngresosPorMembresiasController();
            this.formasPagoController = new VwFormasPagoController();
        }

        public ActionResult Index()
        {
            var membresias = this.membresiasActivasController.ObtenerMembresiasActivas();
            var alumnos = this.alumnosPorClaseController.ObtenerAlumnosPorClase();
            var ingresos = this.ingresosPorMembresiasController.ObtenerIngresosPorMembresias();
            var formasPago = this.formasPagoController.ObtenerFormasPago();

            var model = new DatosInteresModel
            {
                MembresiasActivas = membresias.Select(x => new MembresiasActivasModel(x)).OrderByDescending(x => x.Cantidad).ToList(),
                AlumnosPorClases = alumnos.Select(x => new AlumnosPorClaseModel(x)).OrderByDescending(x => x.CantidadDeAlumnos).ToList(),
                IngresosPorMembresias = ingresos.Select(x => new IngresoPorMembresiaModel(x)).OrderByDescending(x => x.Ingresos).ToList(),
                FormasPago = formasPago.Select(x => new FormaPagoModel(x)).OrderByDescending(x => x.ValorTotal).ToList()
            };

            return this.View(model);
        }
    }
}