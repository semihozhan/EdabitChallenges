using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    internal static class Bigrams
    {
        public static bool CanFind(string[] bigrams, string[] words)
        {
            int cnt = 0;

            for (int i = 0; i < bigrams.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j].Contains(bigrams[i]))
                    {
                        cnt++;
                        break;
                    }
                }
            }



            return cnt == bigrams.Length ? true : false;
        }
    }
}
