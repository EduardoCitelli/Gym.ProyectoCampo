namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class DateTimeExtensionMethods
    {
        public static IEnumerable<DateTime> TodosLosDiasDelMes(int year, int month)
        {
            int days = DateTime.DaysInMonth(year, month);

            for (int day = 1; day <= days; day++)
            {
                yield return new DateTime(year, month, day);
            }
        }

        public static IEnumerable<DateTime> TodosLosDiasDeLaSemana()
        {
            var ahora = DateTime.Today;

            var diaActual = ahora.DayOfWeek;

            int days = (int)diaActual;

            DateTime domingo = ahora.AddDays(-days);

            var daysThisWeek = Enumerable.Range(0, 7)
                                         .Select(d => domingo.AddDays(d))
                                         .ToList();

            return daysThisWeek.Where(x => x.DayOfWeek != DayOfWeek.Sunday).OrderBy(x => x).ToList();
        }

        public static List<DayOfWeek> GetWeeksDays() => Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().ToList();
    }
}