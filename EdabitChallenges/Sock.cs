using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockPairs
{
    public static class Sock
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="socks">ABABC</param>
        /// <returns>2</returns>
        public static int SockPairs(string socks)
        {
            int sockCount = 0;
            List<string> strings = new List<string>();

            foreach (var item in socks)
            {
                if (strings.Contains(item.ToString()))
                {
                    sockCount++;
                    strings.RemoveAll(x=>x.Equals(item.ToString()));
                }
                else
                {
                    strings.Add(item.ToString());
                }
            }


            return sockCount;
        }
    }
}
