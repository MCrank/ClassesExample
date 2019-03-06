using System;

namespace ClassesExample.Legos.Torsos
{
    class SkeletonTorso : Torso
    {
        public SkeletonTorso(int numberOfArms)
            : base(numberOfArms, Sex.Shrug, Colors.Bone, "boney")
        {
        }

        public void Rattle()
        {
            Console.WriteLine("Rattle Rattle...");
            Wave(); // Implicit 'This'  i.e. This.Wave()
        }
    }
}
