using SolidPrinciples;
using System;
using System.IO;

namespace SingleResponsibility_Solution
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.WriteAllText(@"c:\Error.txt", message);
        }
    }

}
