using System;
using System.Configuration;

namespace userSettingsEx.src
{
    class Ex1
    {
        public Ex1 ()
        {
            var Pick = new pickRandomWordFromTextFile();
            Game g = new Game(Pick.Pick());
        } 
    }
}