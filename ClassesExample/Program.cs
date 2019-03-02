using System;

namespace ClassesExample
{
    // Classes have Fields (Internal), Properties (External), Methods (Actions that I can take)
    // Classes are implicitely Internal (Not accessibly outside teh project)
    class Program
    {
        #region Fields
        string _myData = "This is just for me to use";

        #endregion

        #region Property
        // Properties and Fields - two ways to store information
        // Property used ot expose 'state' external to class
        public int Number { get; set; }

        public void DoTheThing()
        {
            Number = 1;
            var x = Number;
        }
        #endregion

        // Access Modifiers
        // Implicit modifiers inside a class are private

        // Static Accessability modifier - Do not need to Instantiate the Class
        // Cannot call non static methods
        static void Main(string[] args)
        {
            var taffy = new Candy("Orange", "Saltwater Taffy", CandyType.Stretchy);

            taffy.SetRating(7, "This is guud!");
            
            Console.WriteLine(taffy);
            Console.ReadLine();

        }
    }
}

// Expression Body Members
