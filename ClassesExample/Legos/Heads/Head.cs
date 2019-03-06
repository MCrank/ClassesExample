using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos.Heads
{
    abstract class Head // Abstract is just to be inherited.  Can never instantiate a new one
    {
        public HairLength HairLength { get; protected set; }
        public Colors Color { get; protected set; }
        public string EarSize { get; protected set; }

        public virtual string Talk()
        {
            return "I'm a talking head!";
        }
    }
}
