namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using Gym.Domain;
    using System;

    public partial class OperacionesSocios : Operable<Socios>
    {
        protected override void LogicaAlta(Socios entity, IRepository<Socios> repository)
        {
            if (repository.ExistId(entity.soc_Codigo))
                throw new Exception("El Codigo Elegido ya existe");

            repository.Add(entity);
        }

        protected override void LogicaParaEliminar(int idEntity, IRepository<Socios> repository)
        {
            var objeto = repository.GetById(idEntity);

            objeto.soc_Activo = false;

            repository.Edit(objeto);
        }

        public void GenerarPagoSocio(Socios socio, Socios_Membresias historico, ComprobanteEmitido comprobante)
        {
            var repositorySocio = this.CrearRepository();
            repositorySocio.Edit(socio);

            var repositoryHistorico = this.uow.GetRepository<Socios_Membresias>();
            repositoryHistorico.Add(historico);

            var repositoryComprobante = this.uow.GetRepository<ComprobanteEmitido>();
            repositoryComprobante.Add(comprobante);

            this.CerrarRepository();
        }
    }
}