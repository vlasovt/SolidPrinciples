using System.Collections.Generic;

namespace SingleResponsibility_Solution
{
    public interface INotificationEngine
    {
        IList<string> ToAddresses { get; set; }
        IList<string> BccAddresses { get; set; }
        string MessageBody { get; set; }
        string Subject { get; set; }

        void Notify(string notification);
    }
}