using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    public static class CupSwagginControl
    {

        /// <summary>
        /// https://edabit.com/challenge/X3btpQQEBeezX4jhK
        /// </summary>
        /// <param name="swaps"></param>
        /// <returns></returns>
        public static string CupSwapping(string[] swaps)
        {
            string control = "B";
            
            foreach (string swap in swaps)
            {
                if (swap.Contains(control))
                {
                    control = swap.Replace(control,"");
                }
            }

            return control;
        }
    }
}
