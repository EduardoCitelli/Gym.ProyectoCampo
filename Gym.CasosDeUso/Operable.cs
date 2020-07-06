namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using System;
    
    public class Operable<T> : IOperable<T> where T : class
    {
        protected UnitOfWork uow;

        public virtual void Eliminar(int idEntity)
        {
            var repository = this.CrearRepository();

            try
            {
                this.LogicaParaEliminar(idEntity, repository);

                this.CerrarRepository();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Alta(T entity)
        {
            var repository = this.CrearRepository();

            try
            {
                this.LogicaAlta(entity, repository);

                this.CerrarRepository();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public virtual void Modificar(T entity)
        {            
            var repository = this.CrearRepository();

            try
            {
                this.LogicaModificacion(entity, repository);

                this.uow.Save();

                this.uow.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected virtual IRepository<T> CrearRepository()
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<T>();

            return repository;
        }

        protected virtual void CerrarRepository()
        {
            this.uow.Save();

            this.uow.Dispose();
        }

        protected virtual void LogicaAlta(T entity, IRepository<T> repository) => repository.Add(entity);

        protected virtual void LogicaModificacion(T entity, IRepository<T> repository) => repository.Edit(entity);

        protected virtual void LogicaParaEliminar(int idEntity, IRepository<T> repository)
        {
            var objeto = repository.GetById(idEntity);

            repository.Remove(objeto);
        }
    }
}
