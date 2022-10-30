using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    public static class DuplicateCharacters
    {
        public static int DuplicateCount(string str)
        {
            char[] chars = str.ToCharArray();

            var value = from i in chars
                        group i by i into g
                        select new { key = g, cnt = g.Count() };

            return value.Count(x => x.cnt > 1);
        }
    }
}
