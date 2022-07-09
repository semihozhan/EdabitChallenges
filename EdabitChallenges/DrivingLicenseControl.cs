using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    public static class DrivingLicenseControl
    {
        /// <summary>
        /// https://edabit.com/challenge/HfpK34Ty4SZhN2d9e
        /// </summary>
        /// <param name="me">Eric</param>
        /// <param name="agents">2</param>
        /// <param name="others">Adam Caroline Rebecca Frank</param>
        /// <returns>40</returns>
        public static int License(string me, int agents, string others)
        {
            string[] shortArray = stringToArray(me, others);
            int count = 0;

            for (int i = 0; i < shortArray.Length; i+= agents)
            {
                count += 20;
                for (int j = i; j < i+ agents; j++)
                {
                    if (shortArray[j]==me) {return count;}
                }
            }
            return count;
        }

        public static string[] stringToArray(string me,string others)
        {
            List<string> shortList = others.Split(" ").ToList();
            shortList.Add(me);
            shortList = shortList.OrderBy(s => s).ToArray().ToList();
            string[] shortArray = shortList.ToArray();
            return shortArray;
        }
    }
}
