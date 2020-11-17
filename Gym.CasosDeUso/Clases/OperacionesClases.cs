namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using Gym.Domain;
    using System;
    
    public partial class OperacionesClases : Operable<Clases>
    {
        protected override void LogicaParaEliminar(int idEntity, IRepository<Clases> repository)
        {
            var objeto = repository.GetById(idEntity);

            if (objeto.cls_Estado == "A")
                throw new Exception("La clase ya está dada de alta y no puede eliminarse, dar de baja primero");

            repository.Remove(objeto);
        }
    }
}
