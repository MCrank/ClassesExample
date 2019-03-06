using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos.Legs
{
    class ShortsLegs : LegsBase
    {
        public ShortsLegs(Length legLength, Colors shortsColor, bool isHairy) : base(legLength, shortsColor)
        {
            Hairy = isHairy;
        }


    }
}
