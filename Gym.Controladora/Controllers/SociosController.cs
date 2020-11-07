namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;

    public class SociosController : IController<Socios>
    {
        private readonly GestionarSocios gestionarSocios;
        private readonly OperacionesSocios operacionesSocios;
        private readonly OperacionesSocios_Membresias operacionesHistorico;
        private readonly GestionarComprobantesEmitidos gestionarComprobantesEmitidos;
        private readonly OperacionesComprobantesEmitidos operacionesComprobantesEmitidos;

        public SociosController()
        {
            this.gestionarSocios = new GestionarSocios();
            this.operacionesSocios = new OperacionesSocios();
            this.operacionesHistorico = new OperacionesSocios_Membresias();
            this.gestionarComprobantesEmitidos = new GestionarComprobantesEmitidos();
            this.operacionesComprobantesEmitidos = new OperacionesComprobantesEmitidos();
        }

        public void Eliminar(int idEntity) => this.operacionesSocios.Eliminar(idEntity);

        public void Guardar(Socios objeto, bool esModificacion)
        {
            if (esModificacion) this.operacionesSocios.Modificar(objeto);

            else this.operacionesSocios.Alta(objeto);
        }

        public ICollection<Socios> Listar() => this.gestionarSocios.Listar();

        public Socios Obtener(int idEntity) => this.gestionarSocios.Obtener(idEntity);

        public Socios ObtenerCompleto(int idEntity) => this.gestionarSocios.ObtenerCompleto(idEntity);

        public bool VerificarMembresias()
        {
            try
            {
                this.VerificarSociosPorClases();

                this.VerificarSociosMensuales();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }

        public string GenerarPagoPremium(Socios socio, Membresias membresia, EnumFormasPago formaPago)
        {
            try
            {
                var socioModificado = this.RelacionarMembresiaAlSocio(socio, membresia, null);

                var historico = this.CrearHistorico(socio, membresia, formaPago);

                var comprobante = this.GenerarComprobante(socio, membresia, formaPago, null);

                var fileName = this.GenerarPdf(comprobante, socioModificado);

                this.operacionesSocios.GenerarPagoSocio(socioModificado, historico, comprobante);
                
                return fileName;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GenerarPagoComun(Socios socio, Membresias membresia, EnumFormasPago formaPago, Actividades actividad)
        {
            try
            {
                var socioModificado = this.RelacionarMembresiaAlSocio(socio, membresia, actividad);

                var historico = this.CrearHistorico(socio, membresia, formaPago);

                var comprobante = this.GenerarComprobante(socio, membresia, formaPago, actividad);

                var fileName = this.GenerarPdf(comprobante, socioModificado);

                this.operacionesSocios.GenerarPagoSocio(socioModificado, historico, comprobante);

                return fileName;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private ComprobanteEmitido GenerarComprobante(Socios socio,Membresias membresia, EnumFormasPago formaPago, Actividades actividad)
        {
            var nroTransaccion = this.gestionarComprobantesEmitidos.ObtenerUltimaTransaccion();

            var comprobante = new ComprobanteEmitido()
            {
                cem_soc_Codigo = socio.soc_Codigo,
                cem_FechaEmision = DateTime.Now,
                cem_FechaVencimiento = DateTime.Now.AddMonths(membresia.Tipo.tmm_CantidadMeses),
                cem_FormaPago = formaPago.ToString(),
                cem_Precio = membresia.mem_Precio,
                cem_NroTransaccion = nroTransaccion + 1,
                cem_Actividad = actividad == null ? string.Empty : actividad.act_Descripcion,
                cem_CantidadClases = !membresia.Tipo.tmm_EsMensual ? membresia.Tipo.tmm_CantidadClases : null
            };

            return comprobante;
        }

        public string GenerarPdf(ComprobanteEmitido comprobante, Socios socio)
        {
            var generador = new GeneradorPdf();

            var result = generador.GenerarComprobante(comprobante, socio);

            return result;
        }

        private Socios_Membresias CrearHistorico(Socios socio, Membresias membresia, EnumFormasPago formaPago)
        {
            var historico = new Socios_Membresias()
            {
                sms_soc_Codigo = socio.soc_Codigo,
                sms_mem_Codigo = membresia.mem_Codigo,
                sms_FechaAlta = DateTime.Now,
                sms_FormaPago = formaPago.ToString(),
                sms_Precio = membresia.mem_Precio
            };

            return historico;
        }        

        private Socios RelacionarMembresiaAlSocio(Socios socio, Membresias membresia, Actividades actividad)
        {
            this.LimpiarSocio(socio);

            socio.soc_mem_Codigo = membresia.mem_Codigo;

            socio.soc_FechaVtoMembresia = DateTime.Today.AddMonths(membresia.Tipo.tmm_CantidadMeses);

            if (actividad != null)
            {
                socio.soc_act_Codigo = actividad.act_Codigo;
                socio.soc_CantidadClasesDisponibles = membresia.Tipo.tmm_CantidadClases;
            }

            return socio;
        }

        private void LimpiarSocio(Socios socio)
        {
            if (socio.Membresia != null)
                socio.Membresia = null;

            if (socio.ActividadInscripta != null)
            {
                socio.ActividadInscripta = null;
                socio.soc_act_Codigo = null;
                socio.soc_CantidadClasesDisponibles = null;
            }
        }

        private void VerificarSociosMensuales()
        {
            var socios = this.gestionarSocios.ListarSociosConMembresiasVencidas();

            foreach (var socio in socios)
            {
                socio.soc_Activo = false;

                socio.soc_mem_Codigo = null;
                socio.soc_FechaVtoMembresia = null;

                this.Guardar(socio, true);
            }
        }

        private void VerificarSociosPorClases()
        {
            var sociosSinCupoDeClase = this.gestionarSocios.ListarSociosConMembresiasSinClases();

            foreach (var socio in sociosSinCupoDeClase)
            {
                socio.soc_Activo = false;

                socio.soc_CantidadClasesDisponibles = null;
                socio.soc_FechaVtoMembresia = null;
                socio.soc_mem_Codigo = null;

                this.Guardar(socio, true);
            }
        }
    }
}