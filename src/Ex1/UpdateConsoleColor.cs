using System;

namespace userSettingsEx.src
{
    public class UpdateConsoleColor
    {
        public UpdateConsoleColor()
        {

        }

        public void Update()
        {
            ManipulateConfigurationFile mcf = new ManipulateConfigurationFile();
            Console.BackgroundColor = mcf.getFileBackgroundColor();
            Console.ForegroundColor = mcf.getFileForegroundColor();
        }

        public void InsertNewColors(string backgroundColor, string foregroundColor)
        {
            ManipulateConfigurationFile mcf = new ManipulateConfigurationFile();

            mcf.setFileBackgroundColor(backgroundColor);
            mcf.setFileForegroundColor(foregroundColor);

            UpdateConsoleColor c = new UpdateConsoleColor();

            Update();
        }
    }
}