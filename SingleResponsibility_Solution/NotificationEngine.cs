using SolidPrinciples;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility_Solution
{
    public class NotificationEngine
    {
        public void Notify(string notification)
        {
            EmailClient.Send(notification);
        }
    }
}
