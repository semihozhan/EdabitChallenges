using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    public static class WeekAfterControl
    {
        public static string WeekAfter(string date)
        {
            DateTime dateTime = DateTime.ParseExact(date, "dd/MM/yyyy", null);
            dateTime = dateTime.AddDays(7);
            date = dateTime.ToString("dd/MM/yyy");
            return date;
        }
    }
}
