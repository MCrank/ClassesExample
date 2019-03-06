using System;

namespace ClassesExample.Legos.Torsos
{
    abstract class Torso
    {
        public int NumberofArms { get; protected set; }
        public string FitnessOfAbdomen { get; protected set; }
        public Sex Sex { get; protected set; }
        public Colors Color { get; protected set; }

        public virtual void Wave()
        {
            Console.WriteLine("Waves hello 0/");
        }

        protected Torso(int numberOfArms, Sex sex, Colors color, string fitnessOfAbdomen)
        {
            NumberofArms = numberOfArms;
            Sex = sex;
            Color = color;
            FitnessOfAbdomen = fitnessOfAbdomen;
        }
    }

    internal enum Sex
    {
        Male,
        Female,
        Other,
        Shrug
    }
}
