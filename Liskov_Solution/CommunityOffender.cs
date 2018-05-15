using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    public class CommunityOffender: Offender
    {
        public override void Release()
        {
            
        }

        public override ExpungeFile Expunge()
        {
            return new ExpungeFile { ExpungeId = -1 };
        }
    }
}
