namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    
    public class Clases_SociosController : IController<Clases_Socios>
    {
        private readonly GestionarSocios GestionarSocios;
        private readonly GestionarClases GestionarClases;
        private readonly GestionarClases_Socios GestionarClases_Socios;
        private readonly OperacionesClases_Socios OperacionesClases_Socios;

        public Clases_SociosController()
        {
            this.OperacionesClases_Socios = new OperacionesClases_Socios();
            this.GestionarClases_Socios = new GestionarClases_Socios();
            this.GestionarClases = new GestionarClases();
            this.GestionarSocios = new GestionarSocios();
        }

        public void Eliminar(int idEntity) => this.OperacionesClases_Socios.Eliminar(idEntity);

        public void Guardar(Clases_Socios objeto, bool esModificacion)
        {
            if (esModificacion) this.OperacionesClases_Socios.Modificar(objeto);
            else this.OperacionesClases_Socios.Alta(objeto);
        }

        public void Guardar(List<Clases_Socios> objetos, Clases clase)
        {
            try
            {
                this.OperacionesClases_Socios.EliminarPorClase(clase.cls_Id);

                foreach (var objeto in objetos)
                    this.OperacionesClases_Socios.Alta(objeto);  
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ICollection<Clases_Socios> Listar() => this.GestionarClases_Socios.Listar();

        public Clases_Socios Obtener(int idEntity) => this.GestionarClases_Socios.Obtener(idEntity);

        public ICollection<Socios> ListarSocios() => this.GestionarSocios.ListarActivos();

        public ICollection<Clases_Socios> ListarPorClase(int idClase) => this.GestionarClases_Socios.ListarPorClase(idClase);

        public bool SalonOcupado(Clases clase) => this.GestionarClases.SalonOcupado(clase);

        public bool ProfesorOcupado(Clases clase) => this.GestionarClases.ProfesorOcupado(clase);
    }
}