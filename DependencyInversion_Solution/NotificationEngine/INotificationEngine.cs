using System.Collections.Generic;

namespace SingleResponsibility_Solution
{
    public interface INotificationEngine
    {
        void Notify(string notification);
    }
}