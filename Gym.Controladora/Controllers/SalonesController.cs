namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SalonesController : IController<Salones>
    {
        private GestionarSalones GestionarSalones;
        private OperacionesSalones OperacionesSalones;

        public SalonesController()
        {
            this.GestionarSalones = new GestionarSalones();
            this.OperacionesSalones = new OperacionesSalones();
        }

        public void Eliminar(int idEntity) => this.OperacionesSalones.Eliminar(idEntity);

        public void Guardar(Salones objeto, bool esModificacion)
        {
            if (esModificacion)
                this.OperacionesSalones.Modificar(objeto);
            else
                this.OperacionesSalones.Alta(objeto);
        }

        public ICollection<Salones> Listar() => this.GestionarSalones.Listar();

        public Salones Obtener(int idEntity) => this.GestionarSalones.Obtener(idEntity);
    }
}