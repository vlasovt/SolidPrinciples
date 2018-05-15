using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsibility_Solution
{
    public class ErrorLogger
    {
        public void Log(string message)
        {
            File.WriteAllText(@"c:\Error.txt", message);
        }
    }
}
