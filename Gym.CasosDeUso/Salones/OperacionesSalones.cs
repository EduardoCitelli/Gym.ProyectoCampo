namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using Gym.Domain;
    using System;

    public partial class OperacionesSalones : Operable<Salones>
    {
        protected override void LogicaAlta(Salones entity, IRepository<Salones> repository)
        {
            if (repository.ExistId(entity.sal_Codigo))
                throw new Exception("El Codigo Elegido ya existe");

            repository.Add(entity);
        }
    }
}
