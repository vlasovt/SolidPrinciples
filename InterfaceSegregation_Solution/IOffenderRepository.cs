using SolidPrinciples;

namespace SingleResponsibility_Solution
{
    public interface IOffenderRepository
    {
        Offender Save(Offender offender);
    }
}