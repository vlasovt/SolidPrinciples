using SolidPrinciples;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility_Solution
{
    public class ConsoleNotificationEngine: INotificationEngine
    {
        public void Notify(string notification)
        {
            Console.WriteLine(notification);
        }
    }
}
