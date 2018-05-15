using SolidPrinciples;

namespace SingleResponsibility_Solution
{
    public class CommunityOffenderRepository: IOffenderRepository
    {
        public Offender Save(Offender offender)
        {
            return (Offender)Database.Save(offender);
        }
    }
}
