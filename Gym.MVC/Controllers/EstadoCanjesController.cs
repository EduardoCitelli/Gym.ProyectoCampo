//namespace Solver.Acopio.Mvc.Controllers
//{
//    using System.Collections.Generic;
//    using System.Web.Mvc;
//    using Newtonsoft.Json;
//    using Solver.Acopio.Mvc.Models;
//    using Solver.Acopio.WCF.Contracts;
//    using Solver.Acopio.WCF.Dtos;
//    using StructureMap;

//    public class EstadoCanjesController : Controller
//    {
//        private readonly IGeneradorListaClientes GeneradorListaClientes;
//        private readonly IGeneradorListaProductos GeneradorListaProductos;
//        private readonly IGeneradorListaMonedas GeneradorListaMonedas;
//        private readonly IGeneradorListaEstadoCanjes GeneradorListaEstadoCanjes;
//        private readonly IvwEstadoCanjesWcf ServicevwEstadoCanjes;

//        private ComboDto[] ListaRepresentantes;
//        private ComboDto[] ListaClientes;
//        private ComboDto[] ListaProductos;
//        private ComboDto[] ListaMonedas;
//        private ComboDto[] ListaEstadoCereal;
//        private ComboDto[] ListaEstadoInsumos;

//        public EstadoCanjesController(
//            IGeneradorListaClientes generadorListaClientes,
//            IGeneradorListaProductos generadorListaProductos,
//            IGeneradorListaMonedas generadorListaMonedas,
//            IGeneradorListaEstadoCanjes generadorListaEstadoCanjes,
//            IvwEstadoCanjesWcf servicevwEstadoCanjes)
//        {
//            ObjectFactory.BuildUp(this);

//            this.GeneradorListaClientes = generadorListaClientes;
//            this.GeneradorListaProductos = generadorListaProductos;
//            this.GeneradorListaMonedas = generadorListaMonedas;
//            this.GeneradorListaEstadoCanjes = generadorListaEstadoCanjes;
//            this.ServicevwEstadoCanjes = servicevwEstadoCanjes;
//        }

//        public ActionResult Index()
//        {
//            this.ListaRepresentantes = this.GeneradorListaClientes.GetListaClientesRepresentantes();
//            this.ListaClientes = this.GeneradorListaClientes.GetListaClientesProductores();
//            this.ListaProductos = this.GeneradorListaProductos.GetLista();
//            this.ListaMonedas = this.GeneradorListaMonedas.GetLista();
//            this.ListaEstadoCereal = this.GeneradorListaEstadoCanjes.GetLista();
//            this.ListaEstadoInsumos = this.GeneradorListaEstadoCanjes.GetLista();

//            var model = this.GenerarModelCargado();
//            return this.View(model);
//        }

//        [HttpPost]
//        public ActionResult Tablas(string tipoCanje, List<string> clcsRepresentantes, List<string> clcsClientes, List<string> idsProductos, List<string> idsMonedas, string estadoCereal, string estadoInsumos)
//        {
//            var listaRepresentantesCodigo = JsonConvert.DeserializeObject<List<int>>(clcsRepresentantes[0]);
//            if (listaRepresentantesCodigo == null)
//                listaRepresentantesCodigo = new List<int>();

//            var listaClientesCodigo = JsonConvert.DeserializeObject<List<int>>(clcsClientes[0]);
//            if (listaClientesCodigo == null)
//                listaClientesCodigo = new List<int>();

//            var listaProductos = JsonConvert.DeserializeObject<List<string>>(idsProductos[0]);
//            if (listaProductos == null)
//                listaProductos = new List<string>();

//            var listaMonedas = JsonConvert.DeserializeObject<List<short>>(idsMonedas[0]);
//            if (listaMonedas == null)
//                listaMonedas = new List<short>();

//            var EstadoCerealId = JsonConvert.DeserializeObject<int>(estadoCereal);

//            var EstadoInsumosId = JsonConvert.DeserializeObject<int>(estadoInsumos);

//            var model = this.GenerarModelCargado(tipoCanje, listaRepresentantesCodigo, listaClientesCodigo, listaProductos, listaMonedas, EstadoCerealId, EstadoInsumosId);

//            return this.PartialView(model);
//        }

//        private EstadosCanjesModel GenerarModelCargado()
//        {
//            var filtros = new DatosFiltradoEstadoCanjesModel(
//                this.ListaRepresentantes,
//                this.ListaClientes,
//                this.ListaProductos,
//                this.ListaMonedas,
//                this.ListaEstadoCereal,
//                this.ListaEstadoInsumos);

//            var model = new EstadosCanjesModel(filtros);
//            return model;
//        }

//        private EstadosCanjesModel GenerarModelCargado(string tipoCanje, List<int> listaCodigoRepresentantes, List<int> listaCodigoClientes, List<string> IdsProductos, List<short> IdsMonedas, int estadoCereal, int estadoInsumos)
//        {
//            var filtros = new DatosFiltradoEstadoCanjesModel(
//                this.ListaRepresentantes,
//                this.ListaClientes,
//                this.ListaProductos,
//                this.ListaMonedas,
//                this.ListaEstadoCereal,
//                this.ListaEstadoInsumos);

//            var canjes = new List<vwEstadoCanjesDto>();

//            var canjesObtenidos = this.ServicevwEstadoCanjes.ObtenerCanjes(tipoCanje, listaCodigoRepresentantes, listaCodigoClientes, IdsProductos, IdsMonedas, estadoCereal, estadoInsumos);

//            canjes.AddRange(canjesObtenidos);

//            var model = new EstadosCanjesModel(filtros, canjes);

//            return model;
//        }
//    }
//}

