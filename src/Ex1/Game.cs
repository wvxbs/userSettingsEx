using System;
using System.Collections.Generic;

namespace userSettingsEx.src
{
    class Game
    {
        private string Word = "";
        private int Attempt = 7;
        private List<char> Letters = new List<char>();
        private List<string> CorrectWord = new List<string>();
        private List<string> Result = new List<string>();

        public Game (string _Word)
        {
            Word = _Word;
            Console.WriteLine(_Word);

            int i = 1;

            while(i < Word.Length)
            {
                Result.Add("_");

                i++;
            }

            Clock();
        }

        private void Clock ()
        {
            while(Attempt > 0)
            {
                getUserInput();
                Console.WriteLine($"Letras digitadas {new String(Letters.ToArray())}");
                Console.WriteLine(String.Join(" ",Result));
            }

            if(isCorrect())
            {
                Console.WriteLine($"Parabéns!!!!!!!!!!!!!!!!!!!!! você ganhou!!!!!!!!!!!!!!!!!!!!!!!!!! a palavra é:{String.Join("", Result)}!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
            else
            {
                Console.WriteLine("Voce gastou todas as tentativas \n\n\t:^{");
            }
        }

        private void getUserInput ()
        {
            bool Run = true;

            while(Run)
            {
                if(isCorrect())
                {
                    Attempt = 0;
                    Run = false;
                }
                Console.WriteLine("Insira a letra");
                char Temp = Console.ReadKey().KeyChar;

                if(Char.IsLetter(Temp))
                {
                    Letters.Add(Temp);
                    if(Word.Contains(Temp))
                    {
                        wordState(Temp);
                    } 
                    else 
                    if(isRepeated(Temp))
                    {
                        Console.WriteLine("Caractere repetido >:^{");
                        Attempt = Attempt;
                    }
                    else
                    Attempt = Attempt -1;
                    Run = false;
                }
                else
                Console.WriteLine("Caractere inválido");
            }
        }

        private void wordState(char c)
        {
            int Position  = Word.IndexOf(c.ToString());

            while(Position != -1)
            {
                Result[Position] = c.ToString();

                Position = Word.IndexOf(c.ToString(), Position +1);
            }
        }

        private bool isCorrect()
        {
            if(Word.Contains(String.Join("",Result)))
                return true;
            else
                return false;
        }

        private bool isRepeated(char c)
        {
            if(String.Join("", Letters).Contains(c))
            {
                return true;
            }

            return false;
        }
    }
}