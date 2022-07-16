using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    public static class TracktheRobot
    {
        public static string direction = "east";
        /// <summary>
        /// https://edabit.com/challenge/6S2aJYTjAka94muDT
        /// </summary>
        /// <param name="steps">..<.<.</param>
        /// <returns>[1, 1]</returns>
        public static int[] TrackRobot(string steps)
        {
            //. means take one step forwards in the current direction.
            //< means turn 90 degrees anticlockwise.
            //> means turn 90 degrees clockwise.
            int[] result = new int[] {0,0};
           
            int controlLeft = 0;
            int controlRight = 0;


            foreach (var item in steps)
            {
                Directions(direction,item);
                if (direction == "east")
                {
                    controlLeft = 1;
                    controlRight = 0;
                }
                else if (direction == "north")
                {
                    controlLeft = 0;
                    controlRight = 1;
                }
                else if (direction == "west")
                {
                    controlLeft = -1;
                    controlRight = 0;

                }
                else if (direction == "south")
                {
                    controlLeft = 0;
                    controlRight = -1;
                }

                if (item == '.')
                {
                    result[0] = result[0] + controlLeft;
                    result[1] = result[1] + controlRight;
                }

                

               // Console.WriteLine("{0} {1} {2}", result[0], result[1], item);
            }

            //Console.WriteLine("{0} {1}", result[0], result[1]);
            return result;
        }


        static void Directions(string directions,char drc)
        {
            direction = directions;
            if (drc == '.')
            {
                direction = direction;
            }
            else if (drc == '<')
            {
                if (directions == "east") direction = "north";
                if (directions == "north") direction = "west";
                if (directions == "west") direction = "south";
                if (directions == "south") direction = "east";
            }
            else if (drc == '>')
            {
                if (directions == "east") direction = "south";
                if (directions == "south") direction = "west";
                if (directions == "west") direction = "north";
                if (directions == "north") direction = "east";
            }
        }
    }
}
