using System;
using System.Configuration;

namespace userSettingsEx.src
{
    class ManipulateConfigurationFile
    {
        public System.ConsoleColor getFileBackgroundColor()
        {
              try
             {                 
                 return (System.ConsoleColor) Enum.Parse(typeof(System.ConsoleColor), ConfigurationManager.AppSettings["BackgroundColor"]);
             }
             catch(Exception e)
             {
              throw e;
             }
        }

        public System.ConsoleColor getFileForegroundColor()
        {
              try
             {                 
                 return (System.ConsoleColor) Enum.Parse(typeof(System.ConsoleColor), ConfigurationManager.AppSettings["ForegroundColor"]);
             }
             catch(Exception e)
             {
              throw e;
             }
        }

        public void setFileBackgroundColor(string Val)
        {
             try
             {                 
                 ConfigurationManager.AppSettings["BackgroundColor"] = Val;
             }
             catch(Exception e)
             {
              throw e;
             }           
        }

        public void setFileForegroundColor(string Val)
        {
             try
             {                 
                 ConfigurationManager.AppSettings["ForegroundColor"] = Val;
             }
             catch(Exception e)
             {
              throw e;
             }           
        }

        public void Save(){}
}}