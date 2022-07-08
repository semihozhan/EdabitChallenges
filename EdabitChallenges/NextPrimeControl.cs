using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    public static class NextPrimeControl
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

        public static List<int> minimalOperations(List<string> words)
        {
            //sddddpeibedjk
            List<int> result = new List<int>();
            
            foreach (var item in words)
            {
                int count = 0;
                char[] rest = item.ToCharArray();
                char temp = '*';
                for (int i=0;i<rest.Length-1;i++)
                {
                    if (rest[i] == rest[i + 1] && temp!=rest[i])
                    {
                        count++;
                        temp = rest[i];
                    }
                    else
                    {
                        temp = '*';
                    }
                     
                       
                }
                result.Add(count);
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            return result;
        }

        public static int minimumSwaps(string brackets)
        {
            
            int leftB = 0,rightB=0;
            for (int i = 0; i < brackets.Length; i++)
            {
                if (brackets[i] == '(') leftB++;
                else{ rightB++; }
            }
            if (rightB != leftB) return -1;
            brackets = brackets + ")";
            int count = 0;
            for (int i = 0; i < brackets.Length-1; i++)
            {
                //(()))(
                if (brackets[i] == '(' && brackets[i+1]!=')') {
                    count++;
                    Console.WriteLine(count + " " + brackets[i] + " " + brackets[i + 1]);
                }
            }

            return count;
        }

        public static List<int> reverseArray(List<int> arr)
        {
            List<int> result = new List<int>();
            int[] reversArray = arr.ToArray();
            var temp = reversArray.Reverse();
            result = temp.ToList();

            /*foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/

            return result;
        }
    }
}
