using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Edabit
{
    public static class ReverseOdd
    {
        public static string ReverseOddFunc(string str)
        {
            string[] strArray = str.Split(' ');

            for (int i=0;i< strArray.Length;i++)
            {
                strArray[i] = strArray[i].Length % 2 != 0 ? ReverseLetter(strArray[i]) : strArray[i];
            }

            return string.Join(" ", strArray);
        }

        public static string ReverseLetter(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
