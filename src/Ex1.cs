using System;

namespace userSettingsEx.src
{
    class Ex1
    {
        public Ex1 (ConsoleColor color)
        {
             try
             {
                 Console.ForegroundColor = color;
                 Hang h = new Hang();
             }
             catch(Exception e)
             {
              throw e;
             }
        }
    }
}
