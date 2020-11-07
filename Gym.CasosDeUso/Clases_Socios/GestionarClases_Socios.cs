namespace Gym.CasosDeUso
{
    using Gym.Domain;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    
    public partial class GestionarClases_Socios : Gestionable<Clases_Socios>
    {
        public ICollection<Clases_Socios> ListarPorClase(int idClase)
        {
            var repository = this.CrearRepository();

            var lista = repository.Query(x => x.css_cls_Id == idClase)
                                   .AsQueryable()
                                   .Include(x => x.Clase)
                                   .Include(x => x.Socio)
                                   .ToList();

            this.CerrarRepository();

            return lista.ToList();
        }        

        public ICollection<Clases_Socios> ListarPorSocio(int codigoSocio)
        {
            var repository = this.CrearRepository();

            var lista = repository
                            .Query(x => x.css_soc_Codigo == codigoSocio)
                            .AsQueryable()
                            .Include(x => x.Clase)
                            .Include(x => x.Socio)
                            .Include(x => x.Clase.Actividad)
                            .Include(x => x.Clase.Titular)
                            .Include(x => x.Clase.Salon)
                            .ToList();

            this.CerrarRepository();

            return lista;
        }
    }
}
