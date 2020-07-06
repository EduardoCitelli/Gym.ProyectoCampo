namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using Gym.Domain;
    using System;
    
    public class OperacionesMembresias
    {
        private UnitOfWork uow;

        public void AgregarMembresia(Membresias membresia)
        {
            this.uow = new UnitOfWork();
            var repository = this.uow.GetRepository<Membresias>();

            try
            {
                repository.Add(membresia);

                this.uow.Save();
                this.uow.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EliminarMembresia(int idMembresia)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<Membresias>();

            var membresia = repository.GetById(idMembresia);

            try
            {
                repository.Remove(membresia);

                this.uow.Save();
                this.uow.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ModificarMembresia(Membresias membresia)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<Membresias>();

            try
            {
                repository.Edit(membresia);

                this.uow.Save();
                this.uow.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}