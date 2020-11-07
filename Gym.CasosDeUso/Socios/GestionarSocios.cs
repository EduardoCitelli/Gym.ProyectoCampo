namespace Gym.CasosDeUso
{
    using Gym.Domain;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    
    public partial class GestionarSocios : Gestionable<Socios>
    {
        private readonly ISociosQueryBuilder queryBuilder;

        public GestionarSocios()
        {
            this.queryBuilder = new SociosQueryBuilder();
        }

        public virtual ICollection<Socios> ListarActivos()
        {
            var repository = this.CrearRepository();

            var lista = repository.GetAll().Where(x => x.VerificarMembresia()).ToList();

            this.CerrarRepository();

            return lista;
        }

        public virtual ICollection<Socios> ListarParaClases(int idActividad)
        {
            var repostitory = this.CrearRepository();

            var query = this.queryBuilder.GetQueryParaClase(idActividad);

            var lista = repostitory.Query(query).Where(x => x.VerificarMembresia()).ToList();

            this.CerrarRepository();

            return lista;
        }

        public virtual ICollection<Socios> ListarSociosConMembresiasVencidas()
        {
            var repository = this.CrearRepository();

            var query = this.queryBuilder.GetQueryConMembresiaVencida();

            var lista = repository.Query(query).ToList();

            this.CerrarRepository();

            return lista;
        }

        public virtual ICollection<Socios> ListarSociosConMembresiasSinClases()
        {
            var repository = this.CrearRepository();

            var query = this.queryBuilder.GetQueryConMembresiaSinClasesDisponibles();

            var lista = repository.Query(query).ToList();

            this.CerrarRepository();

            return lista;
        }

        public Socios ObtenerCompleto(int codigoSocio)
        {
            var repository = this.CrearRepository();

            var objeto = repository.Query(x => x.soc_Codigo == codigoSocio)
                                   .AsQueryable()
                                   .Include(x => x.Membresia)
                                   .Include(x => x.Membresia.Tipo)
                                   .Include(x => x.HistoricoMembresias)
                                   .Include(x => x.ClasesInscriptas)
                                   .FirstOrDefault();

            this.CerrarRepository();

            return objeto;
        }
    }
}