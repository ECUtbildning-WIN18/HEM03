using System;

namespace Unicorn.Domain
{
    class Soldier : Unit
    {
        public string Name { get; }

        public Soldier(string name):base(100, 15)
        {
            Name = name;
        }
        public override void WarScream()
        {
            Console.WriteLine("For the Alamo!");
        }
        public override void PrintStatus()
        {
            Console.WriteLine("Doing well!");
        }
    }
}