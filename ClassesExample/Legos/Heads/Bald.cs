using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos.Heads
{
    class Bald : Head
    {
        // Props
        public int ShineLevel { get; set; }
        public bool HasToupe { get; set; }
        // Fields

        // Constructor

        // Methods
        public void Cut(HairLength newLength)
        {
            HairLength = HairLength.CompletelyBald;
        }

        public override string Talk()
        {
            return "I pity the foo'!";
        }
    }

    internal enum HairLength
    {
        CompletelyBald,
        Stuble,
        Short,
        Medium,
        Long
    }
    
}
