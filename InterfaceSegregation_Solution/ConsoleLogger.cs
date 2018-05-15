using SolidPrinciples;
using System;
using System.IO;

namespace SingleResponsibility_Solution
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.Write(message);
        }
    }

}
