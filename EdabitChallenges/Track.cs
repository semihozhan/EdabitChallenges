using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    internal static class Track
    {
        /// <summary>
        /// https://edabit.com/challenge/g88PKZrCY6sWPBva7
        /// </summary>
        /// <param name="instructions">new string[] { "right 10", "up 50", "left 30", "down 10" }</param>
        /// <returns>int[] { -20, 40 }</returns>
        public static int[] TrackRobot(string[] instructions)
        {
            int x = 0, y = 0;
            foreach (var ins in instructions)
            {
                string[] splitResult = ins.Split(' ');
                switch (splitResult[0])
                {
                    case "right":  x+= Convert.ToInt32(splitResult[1]); break;
                    case "left": x-= Convert.ToInt32(splitResult[1]); break;
                    case "up": y+= Convert.ToInt32(splitResult[1]); break;
                    case "down": y-= Convert.ToInt32(splitResult[1]); break;
                }    
            }
            return new int[]{x,y};
        }
    }
}
