using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    public static class MaximumOccurrenceControl
    {
        /// <summary>
        /// https://edabit.com/challenge/vtdfueRCmpRGyLAGs
        /// </summary>
        /// <param name="text">system admin</param>
        /// <returns>m, s</returns>
        public static string MaxOccur(string text)
        {
            List<string> list = new List<string>();
            int temp = 0;
            string result= "No Repetition";

            var detail = from i in text.ToCharArray()
                         group i by i into i
                         select new { key = i.Key.ToString().ToLower(), cnt = i.Count() };

            foreach (var item in detail)
            {
                if (item.cnt > temp && item.cnt>1)
                {
                    list.Clear();
                    list.Add(item.key);
                    temp = item.cnt;
                    result = String.Join(',', list.OrderBy(x=>x));
                }
                else if (item.cnt == temp && item.cnt > 1)
                {
                    list.Add(item.key);
                    temp = item.cnt;
                    result = String.Join(',', list.OrderBy(x => x));
                }
            }

            

            return result;
        }
    }
}
