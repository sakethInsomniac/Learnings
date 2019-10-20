using LSRLearning.OptimalPath.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSRLearning.OptimalPath.ServiceLib
{
    public class OptimalPathManager
    {
        public static void Instructions()
        {
            Console.Clear();
            Console.WriteLine(Designs.instructions);
            Console.WriteLine("This Console Application helps to find the optimal path for the object to travel from the Desitation to source");
            Console.WriteLine("### Available commands:\n* `F` -move forward 1 unit\n* `B` -move backward 1 unit\n* `R` -turn right 90 degrees\n* `L` -turn left 90 degrees");
            Console.WriteLine("Input Format: Directon|StepsCounts eg: F5 that mean Forward 5 steps");
            Console.WriteLine("We can give these commands by comma saperated value");
            Console.WriteLine("eg: F5,L3,T5,L6");
            Console.WriteLine("\nPress Any Key to Display Menu Again");

        }

        public static void OptimalPath()
        {

            Console.Clear();
            Console.WriteLine(Designs.title);

            #region Get Commands
            Console.WriteLine("Path Eg: F4,L1,B2,R2");
            Console.WriteLine("Please provide the Path you want to go :");
            var path = Console.ReadLine();
            var commandList = Helper.Utility.ConvertStringPathToCommands(path);
            #endregion

            if (commandList != null)
            {
                #region Process Steps
                int posX = 0;
                int posY = 0;
                foreach (var command in commandList)
                {
                    if (command.Direction == 'F')
                    {
                        posY += command.StepsCount;
                    }
                    if (command.Direction == 'B')
                    {
                        posY -= command.StepsCount;
                    }
                    if (command.Direction == 'L')
                    {
                        posX -= command.StepsCount;
                    }
                    if (command.Direction == 'R')
                    {
                        posX += command.StepsCount;
                    }
                }
                #endregion

                //Find the Shortest Steps
                int ShortestSteps = Math.Abs(posX) + Math.Abs(posY);
                Console.WriteLine("Shortest Steps to reach the source is : {0} \n", ShortestSteps);
                Utility.RepeatorEnd();
            }
            else
            {
                Utility.RepeatorEnd();
            }

            Console.WriteLine("Press Any Key to Display Menu Again");
        }
    }
}
