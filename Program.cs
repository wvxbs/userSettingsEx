using System;
using userSettingsEx.src;

namespace userSettingsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            chooseExercise();
        }

        public static void chooseExercise()
        {
            int Select = 0;
            bool Run = true;

            while(Run)
            {
                Console.WriteLine("\n1 rodar jogo\n0 para sair");
                if(int.TryParse(Console.ReadLine(), out Select))
                {
                    switch(Select)
                    {
                        case 1:
                            Ex1 e1 = new Ex1();
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
