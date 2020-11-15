namespace Gym.CasosDeUso
{
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    
    public partial class GestionarClases : Gestionable<Clases>
    {
        private readonly IClasesQueryBuilder queryBuilder;

        public GestionarClases()
        {
            this.queryBuilder = new ClasesQueryBuilder();
        }

        public ICollection<Clases> ListarCompleto()
        {
            var repository = this.CrearRepository();

            var lista = repository.GetAll()
                                  .AsQueryable()
                                  .Include(x => x.Titular)
                                  .Include(x => x.Auxiliar)
                                  .Include(x => x.Actividad)
                                  .Include(x => x.Salon)
                                  .Include(x => x.SociosInscriptos)
                                  .ToList();

            this.CerrarRepository();

            return lista;
        }

        public ICollection<Clases> ListarCompletoFuturasClases()
        {
            var repository = this.CrearRepository();

            var lista = repository.Query(x => x.cls_FechaInicio > DateTime.Today)
                                   .AsQueryable()
                                   .Include(x => x.Titular)
                                   .Include(x => x.Auxiliar)
                                   .Include(x => x.Actividad)
                                   .Include(x => x.Salon)
                                   .Include(x => x.SociosInscriptos)
                                   .OrderBy(x => x.cls_FechaInicio)
                                   .ToList();

            this.CerrarRepository();

            return lista;
        }

        public Clases ObtenerCompleto(int idEntity)
        {
            var repository = this.CrearRepository();

            var objeto = repository.Query(x => x.cls_Id == idEntity)
                                  .AsQueryable()
                                  .Include(x => x.Titular)
                                  .Include(x => x.Auxiliar)
                                  .Include(x => x.Actividad)
                                  .Include(x => x.Salon)
                                  .Include(x => x.SociosInscriptos)
                                  .FirstOrDefault();

            this.CerrarRepository();

            return objeto;
        }

        public bool SalonOcupado(Clases clase)
        {
            var repository = this.CrearRepository();

            var query = this.queryBuilder.ObtenerQuerySalonOcupado(clase);

            var listaClases = repository.Query(query).ToList();

            this.CerrarRepository();

            return listaClases.Any();
        }        

        public bool ProfesorOcupado(Clases clase)
        {
            var repository = this.CrearRepository();

            var query = this.queryBuilder.ObtenerQueryProfesorOcupado(clase);

            var listaClases = repository.Query(query).ToList();

            this.CerrarRepository();

            return listaClases.Any();
        }
    }
}