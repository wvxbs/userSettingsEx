using System;
using userSettingsEx.src;
using System.Configuration;

namespace userSettingsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            chooseExercise();
        }

        public static void getConfigurationFileData()
        {
            var title = ConfigurationManager.AppSettings["title"];
        }

        public static void chooseExercise()
        {
            int Select = 0;
            bool Run = true;

            while(Run)
            {
                Console.WriteLine("\n1 para 1\n2 para 2\n3 para 3\n\n0 para sair");
                if(int.TryParse(Console.ReadLine(), out Select))
                {
                    switch(Select)
                    {
                        case 1:
                            Ex1 e1 = new Ex1(ConsoleColor.Green);
                        break;
                        case 2:
                        break;
                        case 3:
                        break;
                        case 0:
                            Run = false;
                        break;
                        default:
                            Run = false;
                        break;
                    }
                }
            }
        }
    }
}
