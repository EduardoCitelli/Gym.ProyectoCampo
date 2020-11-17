namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using Gym.Domain;
    using System.Linq;
    
    public partial class OperacionesClases_Socios : Operable<Clases_Socios>
    {
        public void EliminarPorClase(int idClase)
        {
            var repository = this.CrearRepository();

            var coleccion = repository.Query(x => x.css_cls_Id == idClase).ToList();

            foreach (var objeto in coleccion)
            {
                var repositorySocios = this.uow.GetRepository<Socios>();

                var socio = repositorySocios.GetById(objeto.css_soc_Codigo);

                if (!socio.Membresia.Tipo.tmm_EsMensual)
                    socio.soc_CantidadClasesDisponibles += 1;

                repository.Remove(objeto);
            }

            this.CerrarRepository();
        }

        protected override void LogicaAlta(Clases_Socios entity, IRepository<Clases_Socios> repository)
        {
            var repositoryClases = this.uow.GetRepository<Clases>();

            var clase = repositoryClases.GetById(entity.css_cls_Id);

            repository.Add(entity);

            if (clase.cls_Estado != "A")
            {
                clase.cls_Estado = "A";

                repositoryClases.Edit(clase);
            }

            var repositorySocios = this.uow.GetRepository<Socios>();

            var socio = repositorySocios.GetById(entity.css_soc_Codigo);

            if (!socio.Membresia.Tipo.tmm_EsMensual)
            {
                socio.soc_CantidadClasesDisponibles -= 1;

                repositorySocios.Edit(socio);
            }            
        }
    }
}