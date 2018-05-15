using SingleResponsibility_Solution;
using System;

namespace SolidPrinciples
{
    public class OffenderManager
    {
        IOffenderRepository offenderRepository;
        ILogger systemLogger;
        INotificationEngine notificationEngine;

        public OffenderManager(IOffenderRepository offenderRepo,
                               ILogger logger,
                               INotificationEngine notifEngine)
        {
            offenderRepository = offenderRepo;
            systemLogger = logger;
            notificationEngine = notifEngine;
        }

        public Offender Save(Offender offender)
        {
            try
            {
                offender = offenderRepository.Save(offender);

                if (offender.OffenderId > 0)
                {
                    notificationEngine.Notify(string.Format("Offender {0} saved", offender.OffenderId));
                }

                systemLogger.Log("Successfull Save operation!");
            }
            catch (Exception exc)
            {
                systemLogger.Log(exc.ToString());
            }

            return offender;
        }
    }
}
