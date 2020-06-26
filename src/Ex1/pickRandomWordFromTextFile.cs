using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace userSettingsEx.src
{
    class pickRandomWordFromTextFile
    {
        List<string> List = new List<string>();
        public pickRandomWordFromTextFile ()
        {
            retrieveDataFromFile();                 
        }

        public string Pick()
        {
            Random r = new Random();
            string [] ListArray = List.ToArray();
            int Num = r.Next(0, ListArray.Length - 1); 

            return ListArray[Num];
        } 

        private void retrieveDataFromFile ()
        {
              StreamReader sw = new StreamReader(@"src\Ex1\text.txt");

              string Str = sw.ReadToEnd();

              foreach (var i in Str.ToCharArray())
              {
                  List.Add(i.ToString());
              }
        }
    }
}