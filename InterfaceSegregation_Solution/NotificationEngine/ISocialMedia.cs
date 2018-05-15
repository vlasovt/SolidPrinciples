using System.Collections.Generic;

namespace SingleResponsibility_Solution
{
    public interface ISocialMedia: INotificationEngine
    {
        string MediaService { get; set; }
        string Account { get; set; }
    }
}