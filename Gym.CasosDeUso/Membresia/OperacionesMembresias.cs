namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using Gym.Domain;
    using System;
    
    public partial class OperacionesMembresias : Operable<Membresias>
    {
        protected override void LogicaAlta(Membresias entity, IRepository<Membresias> repository)
        {
            if (repository.ExistId(entity.mem_Codigo))
                throw new Exception("El Codigo Elegido ya existe");

            repository.Add(entity);
        }
    }
}