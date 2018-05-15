using SolidPrinciples;

namespace SingleResponsibility_Solution
{
    public class CommunityOffenderRepository: IOffenderRepository
    {
        public Offender Save(Offender offender)
        {
            offender.OffenderId = 1;
            offender = (Offender)Database.Save(offender);
            return offender;
        }
    }
}
