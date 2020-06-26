using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace userSettingsEx.src
{
    class manipulateTxtConfigurationFile
    {
        List<string> List = new List<string>();
        public manipulateTxtConfigurationFile (){}

        public void writeDataToFile(string BackgroundColor, string ForegroundColor)
        {
             try
             {                 
                   using(StreamWriter sw = new StreamWriter(@"Config.user.txt"))
                   {
                            sw.Flush();

                            sw.WriteLine(BackgroundColor);
                            sw.WriteLine(ForegroundColor);
                   }
             }
             catch(Exception e)
             {
              throw e;
             }              
        } 

        public ConsoleColor retrieveDataFromFile (int i)
        {
             try
             {                 
                   using(StreamReader sr = new StreamReader(@"Config.user.txt"))
                   {
                            //string Str = sr.();
                            //char [] Val = Str.ToCharArray();

                            return (System.ConsoleColor) Enum.Parse(typeof(System.ConsoleColor), "a");
                   }
             }
             catch(Exception e)
             {
              throw e;
             }
        }
    }
}