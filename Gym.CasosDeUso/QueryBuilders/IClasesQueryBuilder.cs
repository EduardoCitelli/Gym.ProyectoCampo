namespace Gym.CasosDeUso
{
    using Gym.Domain;
    using System;
    using System.Linq.Expressions;

    public interface IClasesQueryBuilder
    {
        Expression<Func<Clases, bool>> ObtenerQueryProfesorOcupado(Clases clase);

        Expression<Func<Clases, bool>> ObtenerQuerySalonOcupado(Clases clase);
    }
}