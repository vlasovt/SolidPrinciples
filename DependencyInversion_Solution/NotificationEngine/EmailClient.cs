using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    public static class EmailClient
    {
        public static void Send(string message, 
            IList<string> ToAddresses, 
            IList<string> BccAddresses, 
            string MessageBody,
            string Subject)
        {

        }
    }
}
