using System;
using System.Collections.Generic;

namespace userSettingsEx.src
{
    class Game
    {
        private string Word = "";
        private List<string> Result = new List<string>(); 

        public Game (string _Word)
        {
            Word = _Word;
            Clock();
        }

        private void Clock ()
        {
            for(int i = 0; i < 7; i++)
            {
                getUserInput();
                if(isCorrect())
                {
                    Console.WriteLine($"Palavra correta! {listToString()}");
                }
                else
                Console.WriteLine($"Letras descobertas: {listToString()}");
            }
        }

        private bool isCorrect()
        {
            foreach (var i in Word)
            {
                foreach (var j in Result)
                {
                    if(i.ToString() == j)
                    {
                        return true;
                    }

                    return false;
                }
                return false;
            }
            return false;
        }

        private void getUserInput ()
        {
            Console.WriteLine("Insira a letra");
            string temp = Console.ReadLine();

            if(temp.Length == 1)
            {
                processString(temp);
            }
            else
            Console.WriteLine("Insira apenas uma letra");
        }

        private int wordSize(string str)
        {
            return str.ToCharArray().Length;
        }

        private void processString(string str)
        {
            var Temp = Word.ToCharArray();

            foreach (char i in Temp)
            {
                if(i == str.ToCharArray()[0])
                {
                    Result.Add(i.ToString());
                }
            }
        }

        private string listToString()
        {
            string Str = "";

            foreach (var i in Result)
            {
                Str = Str + i;
            }

            return Str;
        }
    }
}
