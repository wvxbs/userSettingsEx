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

        public void UpdateFromTxt()
        {
            manipulateTxtConfigurationFile mcf = new manipulateTxtConfigurationFile();
            Console.BackgroundColor = mcf.retrieveDataFromFile(0);
            Console.ForegroundColor = mcf.retrieveDataFromFile(1);
        }

        public void InsertNewColors(string backgroundColor, string foregroundColor)
        {
            ManipulateConfigurationFile mcf = new ManipulateConfigurationFile();

            mcf.setFileBackgroundColor(backgroundColor);
            mcf.setFileForegroundColor(foregroundColor);

            UpdateConsoleColor c = new UpdateConsoleColor();

            Update();
        }

        public void InsertNewColorsToTxt(string backgroundColor, string foregroundColor)
        {
            manipulateTxtConfigurationFile mcf = new manipulateTxtConfigurationFile();

            mcf.writeDataToFile(backgroundColor, foregroundColor);

            UpdateFromTxt();
        }
    }
}