using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Util
{
    public static class DateTimeExtensions
    {
        public static int YearsPassed(this DateTime date)
        {
            if (date > DateTime.Now)
            {
                throw new ArgumentOutOfRangeException(nameof(date), "Future dates are not valid.");
            }
            var age = DateTime.Now.Year - date.Year;
            if (DateTime.Now.Month > date.Month || (DateTime.Now.Month == date.Month && DateTime.Now.Day >= date.Day ))
            {
                age++;
            }
            return age;
        }
    }
}
