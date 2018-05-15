using SolidPrinciples;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility_Solution
{
    public class TwitterNotificationEngine : ISocialMedia
    {
        public string MediaService  { get; set; }
        public string Account { get; set; }

        public void Notify(string notification)
        {
        }
    }
}
