using System;

namespace ClassesExample.Legos.Legs
{
    abstract class LegsBase
    {
        public bool Hairy { get; set; }
        public Colors Color { get; set; }
        public bool CanBend { get; set; }
        public Length Length { get; set; }

        public LegsBase(Length length, Colors color)
        {
            Length = length;
            Color = color;
        }

        public virtual void Jump()
        {
            Console.WriteLine("Weeeeeeeee!!!!!!");
        }

        public void Kick(MiniFigure personToKick)
        {
            Console.WriteLine($"{personToKick.Name} just got kicked by {GetType().Name}. Ha Ha Ha. Your not even a scientist");
        }

        public void Walk()
        {
            Console.WriteLine($"{GetType().Name} took a few steps");
        }


    }

    enum Length
    {
        Short,
        Medium,
        Long,
        SuperLong
    }
}
