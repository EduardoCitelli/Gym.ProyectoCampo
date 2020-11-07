namespace Gym.CasosDeUso
{
    using Gym.Domain;
    using System.Linq;

    public class GestionarComprobantesEmitidos : Gestionable<ComprobanteEmitido>
    {
        public int ObtenerUltimaTransaccion()
        {
            var repository = this.CrearRepository();
            var nro = 0;

            var lista = repository.GetAll().Select(x => x.cem_NroTransaccion);

            if (!lista.Any())
            {
                this.CerrarRepository();
                return nro;
            }

            nro = lista.Max();

            this.CerrarRepository();

            return nro;
        }
    }
}