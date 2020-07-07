namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using Gym.Domain;
    using System;
    using System.Linq;
    
    public class OperacionesTipoMembresias : Operable<TipoMembresias>
    {
        public override void Alta(TipoMembresias tipoMembresias)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<TipoMembresias>();

            try
            {
                repository.Add(tipoMembresias);

                this.uow.Save();

                this.uow.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo guardar el tipo de membresía", ex);
            }
        }

        public override void Eliminar(int idTipoMembresia)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<TipoMembresias>();

            var tipoMembresia = repository.GetById(idTipoMembresia);

            if (tipoMembresia.Membresias.Any())
                throw new Exception("Se encuentran membresias que tienen asignadas este tipo y no puede ser eliminado.");

            try
            {
                repository.Remove(tipoMembresia);

                this.uow.Save();

                this.uow.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("No se Pudo eliminar el tipo de Membresia.", ex);
            }
        }

        public override void Modificar(TipoMembresias tipoMembresias)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<TipoMembresias>();

            try
            {
                repository.Edit(tipoMembresias);

                this.uow.Save();

                this.uow.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo modificar el tipo de membresía.", ex);
            }
        }
    }
}