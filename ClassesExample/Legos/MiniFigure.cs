using ClassesExample.Legos.Heads;
using ClassesExample.Legos.Legs;
using ClassesExample.Legos.Torsos;
using System;

namespace ClassesExample.Legos
{
    class MiniFigure
    {
        public string Name { get; set; }
        public Head Head { get; set; }
        public Torso Torso { get; set; }
        public LegsBase Legs { get; set; }

        public MiniFigure(string name, Head head, Torso torso, LegsBase legs)
        {
            Name = name;
            Head = head;
            Torso = torso;
            Legs = legs;
        }


        public void Greet()
        {
            Legs.Walk();
            Torso.Wave();
            Head.Talk();
            Console.WriteLine("Booya!");
        }

    }
}
