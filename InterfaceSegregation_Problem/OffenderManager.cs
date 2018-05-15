using SingleResponsibility_Solution;
using System;
using System.IO;

namespace SolidPrinciples
{
    public class OffenderManager
    {
        public Offender Save(Offender offender)
        {
            IOffenderRepository offenderRepository = new CommunityOffenderRepository();
            ILogger errorLogger = new FileLogger();
            INotificationEngine notificationEngine = new EmailNotificationEngine();

            try
            {
                offender = offenderRepository.Save(offender);

                if (offender.OffenderId > 0)
                {
                    notificationEngine.Notify(string.Format("Offender {0} saved", offender.OffenderId));
                }
            }
            catch (Exception exc)
            {
                errorLogger.Log(exc.ToString());
            }

            return offender;
        }
    }
}
