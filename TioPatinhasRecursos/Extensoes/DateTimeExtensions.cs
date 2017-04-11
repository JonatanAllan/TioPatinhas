using System;

namespace TioPatinhasRecursos.Extensoes
{
    public static class DateTimeExtensions
    {
        public static bool IsBusinessDay(this DateTime date, bool includeSaturday = false)
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    return true;
                case DayOfWeek.Saturday:
                    return includeSaturday;
                default:
                    return false;
            }
        }

        public static DateTime AddBusinessDays(this DateTime date, int days, bool includeSaturday = false)
        {
            var dayOfWeek = ((int)date.DayOfWeek + (days < 0 ? -12 : 6)) % 7;

            if (includeSaturday)
            {
                return date.AddDays(days + (days + dayOfWeek) / 6);
            }

            if (dayOfWeek == 6)
            {
                days--;
            }
            else if (dayOfWeek == -6)
            {
                days++;
            }

            return date.AddDays(days + (days + dayOfWeek) / 5 * 2);
        }
    }
}