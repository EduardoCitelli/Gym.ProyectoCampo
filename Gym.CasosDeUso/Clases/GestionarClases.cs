namespace Gym.CasosDeUso
{
    using Gym.Domain;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public partial class GestionarClases : Gestionable<Clases>
    {
        public ICollection<Clases> ListarCompleto()
        {
            var repository = this.CrearRepository();

            var lista = repository.GetAll()
                                  .AsQueryable()
                                  .Include(x => x.Titular)
                                  .Include(x => x.Auxiliar)
                                  .Include(x => x.Actividad)
                                  .Include(x => x.Salon)
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
                                  .FirstOrDefault();

            this.CerrarRepository();

            return objeto;
        }

        public bool SalonOcupado(Clases clase)
        {
            var repository = this.CrearRepository();

            var listaClases = repository.Query(x => x.cls_sal_Codigo == clase.cls_sal_Codigo && clase.cls_Estado == "A" &&
                                                   (x.cls_FechaInicio <= clase.cls_FechaInicio && x.cls_FechaFinal >= x.cls_FechaInicio ||
                                                    x.cls_FechaInicio <= clase.cls_FechaFinal && x.cls_FechaFinal >= clase.cls_FechaFinal))
                                                    .ToList();

            this.CerrarRepository();

            return listaClases.Any();
        }

        public bool ProfesorOcupado(Clases clase)
        {
            var repository = this.CrearRepository();

            var listaClases = repository.Query(x => x.cls_pro_Titular == clase.cls_pro_Titular && clase.cls_Estado == "A" &&
                                                   (x.cls_FechaInicio <= clase.cls_FechaInicio && x.cls_FechaFinal >= x.cls_FechaInicio ||
                                                    x.cls_FechaInicio <= clase.cls_FechaFinal && x.cls_FechaFinal >= clase.cls_FechaFinal))
                                                    .ToList();

            this.CerrarRepository();

            return listaClases.Any();
        }
    }
}