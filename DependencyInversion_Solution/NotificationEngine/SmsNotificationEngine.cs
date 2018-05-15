using SolidPrinciples;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility_Solution
{
    public class SmsNotificationEngine: ICellPhone
    {
        public IList<string> PhoneNumber { get; set; }
        public IList<string> SmsServer { get; set; }

        public void Notify(string notification)
        {
        }
    }
}
