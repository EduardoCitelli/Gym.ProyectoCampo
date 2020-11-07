namespace Gym.CasosDeUso
{
    using Common;
    using Gym.Domain;
    using System;
    using System.Linq.Expressions;

    public class SociosQueryBuilder : ISociosQueryBuilder
    {
        public Expression<Func<Socios, bool>> GetQueryConMembresiaVencida()
        {
            Expression<Func<Socios, bool>> query =  x => x.soc_mem_Codigo.HasValue && x.soc_FechaVtoMembresia.HasValue;

            query = query.And(x => x.soc_FechaVtoMembresia < DateTime.Today);

            return query;
        }

        public Expression<Func<Socios, bool>> GetQueryConMembresiaSinClasesDisponibles() => x => x.soc_mem_Codigo.HasValue && !x.Membresia.Tipo.tmm_EsMensual && x.soc_CantidadClasesDisponibles < 1;

        public Expression<Func<Socios, bool>> GetQueryParaClase(int idActividad) => x => x.Membresia.mem_EsPremium || x.soc_act_Codigo.HasValue && x.soc_act_Codigo == idActividad;
    }
}