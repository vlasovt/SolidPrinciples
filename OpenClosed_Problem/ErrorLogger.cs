using SolidPrinciples;
using System;
using System.IO;

namespace SingleResponsibility_Solution
{
    public class ErrorLogger
    {

        public void Log(string message, LoggerType loggerType = LoggerType.File)
        {
            switch (loggerType)
            {
                case LoggerType.Console:
                    Console.Write(message);
                    break;
                case LoggerType.File:
                    File.WriteAllText(@"c:\Error.txt", message);
                    break;
                case LoggerType.Database:
                    Database.Save(message);
                    break;
            }
        }
    }

    public enum LoggerType
    {
        File,
        Console,
        Database
    }
}
