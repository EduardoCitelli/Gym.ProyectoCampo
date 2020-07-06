namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;

    public class SociosController : IController<Socios>
    {
        private readonly GestionarSocios gestionarSocios;
        private readonly OperacionesSocios operacionesSocios;

        public SociosController()
        {
            this.gestionarSocios = new GestionarSocios();
            this.operacionesSocios = new OperacionesSocios();
        }

        public void Eliminar(int idEntity) => this.operacionesSocios.Eliminar(idEntity);

        public void Guardar(Socios objeto, bool esModificacion)
        {
            if (esModificacion) this.operacionesSocios.Modificar(objeto);

            else this.operacionesSocios.Alta(objeto);
        }

        public ICollection<Socios> Listar() => this.gestionarSocios.Listar();

        public Socios Obtener(int idEntity) => this.gestionarSocios.Obtener(idEntity);
    }
}