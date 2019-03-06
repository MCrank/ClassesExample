using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos.Legs
{
    class OrangeLegs : LegsBase
    {
        public OrangeLegs(Length legLength) : base(legLength, Colors.Orange)
        {
            Hairy = true;
            CanBend = true;
        }

        public override void Jump()
        {
            Console.WriteLine("Orange legs lose control and flail about in the air");
        }
    }
}
