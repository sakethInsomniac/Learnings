using LSRLearning.OptimalPath.DataModel;
using LSRLearning.OptimalPath.ServiceLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSRLearning.OptimalPath.Helper
{
    public class Utility
    {
        private static ConsoleKey response;

        #region Converts String Path to Command List
        /// <summary>
        /// Converts the User input path to the Commands
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public static List<Command> ConvertStringPathToCommands(string Path)
        {
            try
            {
                var commandList = new List<Command>();
                string[] stringList = Path.Split(',');
                foreach (var stringItem in stringList)
                {
                    if (stringItem.Length == 2)
                    {
                        if (stringItem[0] == 'F' || stringItem[0] == 'L' || stringItem[0] == 'B' || stringItem[0] == 'R')
                        {
                            commandList.Add(new Command { Direction = stringItem[0], StepsCount = int.Parse(stringItem[1].ToString()) });
                        }
                        else
                        {
                            Console.WriteLine("Input Direction Is Wrong Please Try Again  Error: " + stringItem[0]);
                            return null;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input Format is Wrong Please Try Again Error: " + stringItem);
                        return null;
                    }
                }
                return commandList;

            }
            catch(Exception ex)
            {
                Console.WriteLine("Wrong Input Format");
                return null;
            }   
            
        }
        #endregion

        #region Repeat Process or End Process
        public static void RepeatorEnd()
        {
            do
            {
                Console.Write("Do You Want to Try Again? [y/n] ");
                response = Console.ReadKey(false).Key;   // true is intercept key (dont show), false is show
                if (response != ConsoleKey.Enter)
                    Console.WriteLine();

            } while (response != ConsoleKey.Y && response != ConsoleKey.N);

            if (response == ConsoleKey.Y)
            {
                OptimalPathManager.OptimalPath();
            }
            else
            {
                Console.Clear();
                RoboStart.Main();
            }
        }
        #endregion
    }
}
