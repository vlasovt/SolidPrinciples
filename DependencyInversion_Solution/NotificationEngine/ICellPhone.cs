using System.Collections.Generic;

namespace SingleResponsibility_Solution
{
    public interface ICellPhone: INotificationEngine
    {
        IList<string> PhoneNumber { get; set; }
        IList<string> SmsServer { get; set; }
    }
}