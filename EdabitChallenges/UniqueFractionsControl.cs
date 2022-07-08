using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    public static class UniqueFractionsControl
    {
        /// <summary>
        /// https://edabit.com/challenge/FXt7yKLgFi7SW6JBa
        /// </summary>
        /// <returns></returns>
        public static double UniqueFract()
        {
            double result = 0;
            for (double i = 1; i < 10; i++)
            {
                for (double j = 1; j < 10; j++)
                {
                    if (i / j < 1) {
                        result = result + (i / j);  
                    };
                }
            }
            return result;
        }
    }
}
