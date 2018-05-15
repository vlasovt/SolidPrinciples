using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    public class Offender
    {
        public int OffenderId { get; set; }

        public string OffenderName { get; set; }

        public bool Expunged { get; set; }

        public bool Released { get; set; }

        public virtual ExpungeFile Expunge()
        {
            Expunged = true;
            return new ExpungeFile { ExpungeId = new Random().Next(1, 13) };
        }

        public virtual void Release()
        {
            Released = true;
        }
    }
}
