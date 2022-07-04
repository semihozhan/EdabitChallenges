using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    public static class Legendres
    {
        /// <summary> 
        /// https://edabit.com/challenge/Ktr9CQidBThMSMttH
        /// </summary>
        /// <param name="p">5</param>
        /// <param name="n">100</param>
        /// <returns>24</returns>
        public static int LegendresFormula(int p, int n)
        {
            double resultCount = 0;
            for (int i = 1; i < n; i++)
            {
                if (Math.Pow(p, i) > n) break;
                resultCount += Math.Floor(n /Math.Pow(p, i));
            }
            return Convert.ToInt32(resultCount);
        }
    }
}
