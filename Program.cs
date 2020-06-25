using System;
using userSettingsEx.src;

namespace userSettingsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            UpdateConsoleColor c = new UpdateConsoleColor();

            c.Update();
            runExercise();
        }

        public static void runExercise()
        {
            int Select = 0;
            bool Run = true;


            while(Run)
            {
                Console.WriteLine("\n1) Rodar jogo\n2) Mudar cores\n\n0) Sair");
                if(int.TryParse(Console.ReadLine(), out Select))
                {
                    switch(Select)
                    {
                        case 1:
                            Play();
                        break;
                        case 2:
                            ModifyColours();
                        break;
                        case 0:
                            Run = false;
                        break;
                        default:
                        break;
                           
                    }
                }
            }
        }

        public static void Play()
        {
            Ex1 e1 = new Ex1();
        }

        public static void ModifyColours()
        {
            string [] ColorArr = new string [6]{"Black", "White", "Yellow", "Green", "Red", "Blue"};
            string [] DisplayColorArr = new string [6]{"Preto", "Branco", "Amarelo", "Verde", "Vermelho", "Azul"};
            bool Run = true;
            int backgroundColorIndex = 0;
            int foregroundColorIndex = 0;
            string backgroundColor = "";
            string foregroundColor = "";

                while(Run)
                {
                            Console.WriteLine($"\n\nSelecione a cor do fundo:\n\n\t1) {DisplayColorArr[0]}\n\t2) {DisplayColorArr[1]}\n\t3) {DisplayColorArr[2]}\n\t4) {DisplayColorArr[3]}\n\t5) {DisplayColorArr[4]}\n\t6) {DisplayColorArr[5]}\n\n0 para sair");
                            if(int.TryParse(Console.ReadLine(), out backgroundColorIndex))
                            {
                                switch(backgroundColorIndex)
                                {
                                    case 1:
                                        backgroundColor = ColorArr[0];
                                    break;
                                    case 2:
                                        backgroundColor = ColorArr[1];
                                    break;
                                    case 3:
                                        backgroundColor = ColorArr[2];
                                    break;
                                    case 4:
                                        backgroundColor = ColorArr[3];
                                    break;
                                    case 5:
                                        backgroundColor = ColorArr[4];
                                    break;
                                    case 6:
                                        backgroundColor = ColorArr[5];
                                    break;
                                    case 0:
                                        Run = false;
                                    break;
                                    default:
                                        Run = false;
                                    break;
                                }
                            }

                            Console.WriteLine($"\n\nSelecione a cor das letras:\n\n\t1) {DisplayColorArr[0]}\n\t2) {DisplayColorArr[1]}\n\t3) {DisplayColorArr[2]}\n\t4) {DisplayColorArr[3]}\n\t5) {DisplayColorArr[4]}\n\t6) {DisplayColorArr[5]}\n\n0 para sair");
                            if(int.TryParse(Console.ReadLine(), out foregroundColorIndex))
                            {
                                switch(foregroundColorIndex)
                                {
                                    case 1:
                                        foregroundColor = ColorArr[0];
                                    break;
                                    case 2:
                                        foregroundColor = ColorArr[1];
                                    break;
                                    case 3:
                                        foregroundColor = ColorArr[2];
                                    break;
                                    case 4:
                                        foregroundColor = ColorArr[3];
                                    break;
                                    case 5:
                                        foregroundColor = ColorArr[4];
                                    break;
                                    case 6:
                                        foregroundColor = ColorArr[5];
                                    break;
                                    case 0:
                                        Run = false;
                                    break;
                                    default:
                                        Run = false;
                                    break;
                                }
                            }

                            UpdateConsoleColor c = new UpdateConsoleColor();

                            c.InsertNewColors(backgroundColor, foregroundColor);

                            Run = false;
                }
        }
    }
}