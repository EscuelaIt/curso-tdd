using System;

namespace EscuelaIT.TDD.Week.Runtime
{
    public static class DateExtensions
    {
        public static DateTime EndOfTheWeek(this DateTime time)
        {
            var nextMonday = time.AddDays(1);
            while(nextMonday.DayOfWeek != DayOfWeek.Monday)
                nextMonday = nextMonday.AddDays(1);
            
            return nextMonday.Date;
        }
    }
}