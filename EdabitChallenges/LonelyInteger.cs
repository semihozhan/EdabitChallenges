using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    internal static class LonelyInteger
    {
        public static IEnumerable<int> CanFindLonely(int[] intArr)
        {

            var res = from p in intArr
                      group p by p into g
                      where g.Count() < 2
                      select g.Key;

            return res;
        }
    }
}
