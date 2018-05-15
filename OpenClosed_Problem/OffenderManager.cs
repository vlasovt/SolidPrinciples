using SingleResponsibility_Solution;
using System;
using System.IO;

namespace SolidPrinciples
{
    public class OffenderManager
    {
        public Offender Save(Offender offender)
        {
            var offenderRepository = new OffenderRepository();
            var errorLogger = new ErrorLogger();
            var notificationEngine = new NotificationEngine();

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
                errorLogger.Log(exc.ToString(),LoggerType.Database);
            }

            return offender;
        }
    }
}
