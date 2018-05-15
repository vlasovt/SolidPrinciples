﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    public class FacilityOffender: Offender
    {
        public override ExpungeFile Expunge()
        {
            Expunged = false;
            return new ExpungeFile();
        }
    }
}
