namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;
    
    public class Socios_MembresiasController : IController<Socios_Membresias>
    {
        private readonly GestionarSocios_Membresias gestionar;
        private readonly OperacionesSocios_Membresias operaciones;

        public Socios_MembresiasController()
        {
            this.gestionar = new GestionarSocios_Membresias();
            this.operaciones = new OperacionesSocios_Membresias();
        }

        public void Eliminar(int idEntity) => this.operaciones.Eliminar(idEntity);

        public void Guardar(Socios_Membresias objeto, bool esModificacion)
        {
            if (esModificacion)
                this.operaciones.Modificar(objeto);
            else
                this.operaciones.Alta(objeto);
        }

        public ICollection<Socios_Membresias> Listar() => this.gestionar.Listar();

        public Socios_Membresias Obtener(int idEntity) => this.gestionar.Obtener(idEntity);
    }
}