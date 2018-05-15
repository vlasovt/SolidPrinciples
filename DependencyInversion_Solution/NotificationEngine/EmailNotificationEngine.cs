using SolidPrinciples;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility_Solution
{
    public class EmailNotificationEngine: IEmail
    {
        public IList<string> ToAddresses { get; set; }
        public IList<string> BccAddresses { get; set; }
        public string MessageBody { get; set; }
        public string Subject { get; set; }

        public void Notify(string notification)
        {
            EmailClient.Send(notification, ToAddresses, BccAddresses, MessageBody, Subject);
        }
    }
}
