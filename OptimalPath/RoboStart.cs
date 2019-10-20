using LSRLearning.OptimalPath.Helper;
using LSRLearning.OptimalPath.ServiceLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSRLearning.OptimalPath
{
    public class RoboStart
    {
        public static void Main()
        {
            while (true)
            {
                switch (Menu())
                {
                    case 1:
                        OptimalPathManager.Instructions();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        OptimalPathManager.OptimalPath();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine(Designs.robo);
                        Console.WriteLine("Thank You. Press Any Key to Exit Console");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Input. Please Choose Option from Menu");
                        Console.WriteLine("\nPress Any Key to Continue Again");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            }

        }

        #region Program Menu
        /// <summary>
        ///  Display the Program Menu
        /// </summary>
        /// <returns> Int </returns>
        public static int Menu()
        {
            int option = 0;
            try
            {


                Console.WriteLine(Designs.title);

                Console.WriteLine("|-------------------------------------------------|");
                Console.WriteLine("| 1 - Instructions                                |");
                Console.WriteLine("| 2 - Find Optimal Path                           |");
                Console.WriteLine("| 3 - Exit                                        |");
                Console.WriteLine("|-------------------------------------------------|");
                Console.WriteLine("Select your option (enter a selection number): ");
                option = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {

            }
           
            return option;
        }
        #endregion
    }
}
