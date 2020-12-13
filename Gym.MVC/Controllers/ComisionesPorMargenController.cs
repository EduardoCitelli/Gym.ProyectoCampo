//namespace Solver.Acopio.Mvc.Controllers
//{
//    using System.Collections.Generic;
//    using System.Web.Mvc;
//    using Newtonsoft.Json;
//    using Solver.Acopio.Mvc.Models;
//    using Solver.Acopio.Service;
//    using Solver.Acopio.WCF.Contracts;
//    using Solver.Acopio.WCF.Dtos;
//    using StructureMap;

//    public class ComisionesPorMargenController : Controller
//    {
//        private readonly IGeneradorListaClientes generadorListaClientes;
//        private readonly IGeneradorListaMonedas generadorListaMonedas;
//        private readonly IGeneradorListaPeriodosComision generadorListaPeriodosComision;

//        private readonly IvwComisionesPorMargenWcf servicevwComisionesPorMargen;
//        private readonly IBonusWcf serviceBonus;
//        private readonly IComisionesPorMargenDetalleWcf serviceComisionesPorMargenDetalle;
//        private readonly IServiceTiposMonedas serviceTiposMonedas;

//        private ComboDto[] ListaRepresentantes;
//        private ComboDto[] ListaMonedas;
//        private ComboDto[] ListaPeriodos;

//        public ComisionesPorMargenController(
//            IGeneradorListaClientes generadorListaClientes,
//            IGeneradorListaMonedas generadorListaMonedas,
//            IGeneradorListaPeriodosComision generadorListaPeriodosComision,
//            IvwComisionesPorMargenWcf servicevwComisionesPorMargen,
//            IBonusWcf serviceBonus,
//            IComisionesPorMargenDetalleWcf serviceComisionesPorMargenDetalle,
//            IServiceTiposMonedas serviceTiposMonedas)
//        {
//            ObjectFactory.BuildUp(this);

//            this.generadorListaClientes = generadorListaClientes;
//            this.generadorListaMonedas = generadorListaMonedas;
//            this.generadorListaPeriodosComision = generadorListaPeriodosComision;

//            this.servicevwComisionesPorMargen = servicevwComisionesPorMargen;
//            this.serviceBonus = serviceBonus;
//            this.serviceComisionesPorMargenDetalle = serviceComisionesPorMargenDetalle;
//            this.serviceTiposMonedas = serviceTiposMonedas;
//        }

//        public ActionResult Index()
//        {
//            this.ListaRepresentantes = this.generadorListaClientes.GetListaClientesRepresentantes();
//            this.ListaMonedas = this.generadorListaMonedas.GetLista();
//            this.ListaPeriodos = this.generadorListaPeriodosComision.GetLista();

//            return this.View(this.GenerarModelCargado());
//        }

//        [HttpPost]
//        public ActionResult Tablas(List<string> clcRepresentantes, List<string> idsMonedas, List<string> idsPeriodos)
//        {
//            var listaRepresentantesCodigo = JsonConvert.DeserializeObject<List<int>>(clcRepresentantes[0]);
//            if (listaRepresentantesCodigo == null)
//                listaRepresentantesCodigo = new List<int>();

//            var listaMonedas = JsonConvert.DeserializeObject<List<short>>(idsMonedas[0]);
//            if (listaMonedas == null)
//                listaMonedas = new List<short>();

//            var listaPeriodos = JsonConvert.DeserializeObject<List<int>>(idsPeriodos[0]);
//            if (listaPeriodos == null)
//                listaPeriodos = new List<int>();

//            var model = this.GenerarModelCargado(listaRepresentantesCodigo, listaMonedas, listaPeriodos);

//            return this.PartialView(model);
//        }

//        private ComisionesPorMargenModel GenerarModelCargado()
//        {
//            var filtros = new DatosFiltradoComisionesPorMargenModel(this.ListaPeriodos, this.ListaRepresentantes, this.ListaMonedas);

//            return new ComisionesPorMargenModel(filtros);
//        }

//        private ComisionesPorMargenModel GenerarModelCargado(List<int> listaCodigosRepresentante, List<short> listaMonedas, List<int> listaPeriodos)
//        {
//            var filtros = new DatosFiltradoComisionesPorMargenModel(this.ListaPeriodos, this.ListaRepresentantes, this.ListaMonedas);

//            var comisiones = new List<vwComisionesPorMargenDto>();

//            var comisionesObtenidas = this.servicevwComisionesPorMargen.ObtenerComisiones(listaCodigosRepresentante, listaMonedas, listaPeriodos);

//            comisiones.AddRange(comisionesObtenidas);

//            var listaBonus = this.serviceBonus.ObtenerTodos();

//            var model = new ComisionesPorMargenModel(filtros, comisiones, listaBonus);

//            return model;
//        }

//        [HttpPost]
//        public ActionResult Detalle(int obj_Id, short codigoMonedaComprobante)
//        {
//            var simboloMoneda = this.serviceTiposMonedas.ObtenerUno(codigoMonedaComprobante).tmo_Simbolo;

//            var detalles = this.serviceComisionesPorMargenDetalle.ObtenerPorIdObjetivo(obj_Id);

//            var model = new ComisionesPorMargenDetalleReporteModel(detalles, simboloMoneda);

//            return this.PartialView(model);
//        }

//        [HttpPost]
//        public ActionResult ModalBonus(string descripcion, decimal importe, decimal porcentaje, decimal indice, int cantidadRepr, decimal comision)
//        {
//            var model = new BonusModel()
//            {
//                Descripcion = descripcion,
//                ValorBonus = importe,
//                PorcentajeRepresentante = porcentaje,
//                IndiceRepresentante = indice,
//                CantidadRepresentantes = cantidadRepr,
//                Importe = comision
//            };

//            return this.PartialView(model);
//        }
//    }
//}