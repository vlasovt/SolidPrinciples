using SingleResponsibility_Solution;
using SolidPrinciples;
using System;

namespace InterfaceSegregation_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var offenderManager = new OffenderManager(new CommunityOffenderRepository(),
                                                      new ConsoleLogger(),
                                                      new ConsoleNotificationEngine());

            offenderManager.Save(new Offender());

            Console.Read();
        }
    }
}
