using SolidPrinciples;
using System;
using System.IO;

namespace SingleResponsibility_Solution
{
    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Database.Save(message) ;
        }
    }

}
