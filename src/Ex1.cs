using System;
using System.Configuration;

namespace userSettingsEx.src
{
    class Ex1
    {
        public Ex1 ()
        {
             try
             {                 
                 Console.ForegroundColor = (ConsoleColor) Enum.Parse(typeof(ConsoleColor),  ConfigurationManager.AppSettings["BackgroundColor"]);
                 Hang h = new Hang(); 
             }
             catch(Exception e)
             {
              throw e;
             }
        }

        public static string getConfigurationFileData()
        {
            return"";
        }
    }
}
