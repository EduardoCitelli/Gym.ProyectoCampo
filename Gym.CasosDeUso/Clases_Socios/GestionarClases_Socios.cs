namespace Gym.CasosDeUso
{
    using Gym.Domain;
    using System.Collections.Generic;
    using System.Linq;
    
    public partial class GestionarClases_Socios : Gestionable<Clases_Socios>
    {
        public ICollection<Clases_Socios> ListarPorClase(int idClase)
        {
            var repository = this.CrearRepository();

            var lista = repository.Query(x => x.css_cls_Id == idClase);

            return lista.ToList();
        }        
    }
}
