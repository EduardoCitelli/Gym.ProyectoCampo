namespace Gym.CasosDeUso
{
    using Common;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GestionarVwHorariosAlta : Gestionable<VwHorariosAlta>
    {
        public IEnumerable<VwHorariosAlta> ListarClasesSemanales()
        {
            var repository = this.CrearRepository();

            var diasDeLaSemana = DateTimeExtensionMethods.TodosLosDiasDeLaSemana();

            var lunes = diasDeLaSemana.Where(x => x.DayOfWeek == DayOfWeek.Monday).FirstOrDefault();
            var sabado = diasDeLaSemana.Where(x => x.DayOfWeek == DayOfWeek.Saturday).FirstOrDefault().AddHours(23).AddMinutes(59);

            var lista = repository.Query(x => x.Inicio >= lunes && x.Inicio <= sabado).ToList();

            this.CerrarRepository();

            return lista;
        }

        public IEnumerable<VwHorariosAlta> ListarClasesSemanalesPorSalon(int codigoSalon)
        {
            var repository = this.CrearRepository();

            var diasDeLaSemana = DateTimeExtensionMethods.TodosLosDiasDeLaSemana();

            var lunes = diasDeLaSemana.Where(x => x.DayOfWeek == DayOfWeek.Monday).FirstOrDefault();
            var sabado = diasDeLaSemana.Where(x => x.DayOfWeek == DayOfWeek.Saturday).FirstOrDefault().AddHours(23).AddMinutes(59);

            var lista = repository.Query(x => x.Inicio >= lunes && x.Inicio <= sabado && x.CodigoSalon == codigoSalon).ToList();

            this.CerrarRepository();

            return lista;
        }
    }
}
