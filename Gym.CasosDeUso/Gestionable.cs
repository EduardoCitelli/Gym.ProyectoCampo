namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using System.Collections.Generic;
    using System.Linq;
    
    public class Gestionable<T> : IGestionable<T> where T : class
    {
        protected UnitOfWork uow;

        public virtual ICollection<T> Listar()
        {
            var repository = this.CrearRepository();

            var lista = repository.GetAll().ToList();

            this.CerrarRepository();

            return lista;
        }

        public virtual T Obtener(int idEntity)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<T>();

            var objeto = repository.GetById(idEntity);

            this.CerrarRepository();

            return objeto;
        }

        protected virtual IRepository<T> CrearRepository()
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<T>();

            return repository;
        }

        protected virtual void CerrarRepository() => this.uow.Dispose();
    }
}
