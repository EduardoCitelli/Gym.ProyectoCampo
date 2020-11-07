namespace Gym.CasosDeUso
{
    using Gym.Domain;
    using System;
    using System.Linq.Expressions;

    public interface ISociosQueryBuilder
    {
        Expression<Func<Socios, bool>> GetQueryConMembresiaSinClasesDisponibles();

        Expression<Func<Socios, bool>> GetQueryConMembresiaVencida();

        Expression<Func<Socios, bool>> GetQueryParaClase(int idActividad);
    }
}