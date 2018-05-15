using SolidPrinciples;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var offenders = new List<Offender>
             {
                 new Offender(),
                 new CommunityOffender(),
                 new FacilityOffender(),
             };

            foreach (var offender in offenders)
            {
                try
                {
                    var expunge = offender.Expunge();
                    var expungeId = expunge.ExpungeId;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }

            foreach (var offender in offenders)
            {
                try
                {
                    offender.Release();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
