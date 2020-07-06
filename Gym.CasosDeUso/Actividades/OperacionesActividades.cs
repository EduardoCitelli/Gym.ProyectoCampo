namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using Gym.Domain;
    using System;

    public partial class OperacionesActividades : Operable<Actividades>
    {
        protected override void LogicaAlta(Actividades entity, IRepository<Actividades> repository)
        {
            if (repository.ExistId(entity.act_Codigo))
                throw new Exception("El Codigo Elegido ya existe");

            repository.Add(entity);
        }
    }
}