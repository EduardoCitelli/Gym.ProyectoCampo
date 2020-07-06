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
    }
}