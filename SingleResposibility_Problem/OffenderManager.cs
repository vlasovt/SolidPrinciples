using System;
using System.IO;

namespace SolidPrinciples
{
    public class OffenderManager
    {
        public Offender Save(Offender offender)
        {
            try
            {
                offender = (Offender)Database.Save(offender);

                if (offender.OffenderId > 0)
                {
                    SendNotification(string.Format("Offender {0} saved", offender.OffenderId));
                }
            }
            catch (Exception exc)
            {
                File.WriteAllText(@"c:\Error.txt", exc.ToString());
            }

            return offender;
        }

        private void SendNotification(string message)
        {
            EmailClient.Send(message);
        }
    }
}
