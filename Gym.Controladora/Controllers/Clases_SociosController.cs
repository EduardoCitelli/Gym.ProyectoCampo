namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    
    public class Clases_SociosController : IController<Clases_Socios>
    {
        private readonly GestionarSocios gestionarSocios;
        private readonly GestionarClases gestionarClases;
        private readonly GestionarClases_Socios gestionarClases_Socios;

        private readonly OperacionesClases_Socios operacionesClases_Socios;

        public Clases_SociosController()
        {
            this.operacionesClases_Socios = new OperacionesClases_Socios();

            this.gestionarClases_Socios = new GestionarClases_Socios();
            this.gestionarClases = new GestionarClases();
            this.gestionarSocios = new GestionarSocios();
        }

        public void Eliminar(int idEntity) => this.operacionesClases_Socios.Eliminar(idEntity);

        public void Guardar(Clases_Socios objeto, bool esModificacion)
        {
            if (esModificacion) this.operacionesClases_Socios.Modificar(objeto);
            else this.operacionesClases_Socios.Alta(objeto);
        }

        public void Guardar(List<Clases_Socios> objetos, Clases clase)
        {
            try
            {
                this.operacionesClases_Socios.EliminarPorClase(clase.cls_Id);

                foreach (var objeto in objetos)
                {
                    this.operacionesClases_Socios.Alta(objeto);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ICollection<Clases_Socios> Listar() => this.gestionarClases_Socios.Listar();

        public Clases_Socios Obtener(int idEntity) => this.gestionarClases_Socios.Obtener(idEntity);

        public ICollection<Socios> ListarSocios() => this.gestionarSocios.ListarActivos();

        public ICollection<Socios> ListarSociosParaActividad(int idActividad) => this.gestionarSocios.ListarParaClases(idActividad);

        public ICollection<Clases_Socios> ListarPorClase(int idClase) => this.gestionarClases_Socios.ListarPorClase(idClase);

        public ICollection<Clases_Socios> ListarPorSocio(int codigoSocio) => this.gestionarClases_Socios.ListarPorSocio(codigoSocio);

        public bool SalonOcupado(Clases clase) => this.gestionarClases.SalonOcupado(clase);

        public bool ProfesorOcupado(Clases clase) => this.gestionarClases.ProfesorOcupado(clase);
    }
}