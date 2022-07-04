using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    public static class NextPriceControl
    {
        static int[] controlPrime = { 2, 3, 5, 7 };


        /// <summary>
        /// https://edabit.com/challenge/FKb8JY75nkaHz7B3F
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int NextPrime(int num)
        {
            bool result = PrimeControl(num);
            int resultPrime = 0;
            if (result)
            {
                while (result)
                {
                    num++;
                    result = PrimeControl(num);
                }
                resultPrime = num;
            }
            return result ? (controlPrime.Contains(num)) ? num : resultPrime : num;
        }
        private static bool PrimeControl(int num)
        {
            return Enumerable.Range(0, controlPrime.Length).Any(i => num % controlPrime[i] == 0);
        }
    }
}
