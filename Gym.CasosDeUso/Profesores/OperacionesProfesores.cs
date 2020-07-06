namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using Gym.Domain;
    using System;
    
    public partial class OperacionesProfesores : Operable<Profesores>
    {
        protected override void LogicaAlta(Profesores entity, IRepository<Profesores> repository)
        {
            if (repository.ExistId(entity.pro_Codigo))
                throw new Exception("El Codigo Elegido ya existe");

            repository.Add(entity);
        }
    }
}