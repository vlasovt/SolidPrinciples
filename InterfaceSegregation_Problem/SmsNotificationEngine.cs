using SolidPrinciples;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility_Solution
{
    public class SmsNotificationEngine: INotificationEngine
    {
        public IList<string> ToAddresses { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<string> BccAddresses { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MessageBody { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Notify(string notification)
        {


        }
    }
}
