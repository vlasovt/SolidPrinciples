using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    public class CommunityOffender: Offender
    {
        public override void Release()
        {
            new NotImplementedException();
        }

        public new ExpungeFile Expunge()
        {
            return new ExpungeFile { ExpungeId = -1 };
        }
    }
}
