using SolidPrinciples;

namespace SingleResponsibility_Solution
{
    public class OffenderRepository
    {
        public Offender Save(Offender offender)
        {
            return (Offender)Database.Save(offender);
        }
    }
}
