using SolidPrinciples;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility_Solution
{
    public class EmailNotificationEngine: INotificationEngine
    {
        public void Notify(string notification)
        {
            EmailClient.Send(notification);
        }
    }
}
