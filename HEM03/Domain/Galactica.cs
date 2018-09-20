using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Galactica : Vehicle 
    {
        public string Commander { get; }
        public string FirstMate { get; }

        public Galactica(string commander, string firstMate) :base("Ship 4K", "X2000", "FTL", "William Adaman")
        {
            FirstMate = firstMate;
            Commander = commander;
        }

        public override void Drive()
        {
            Console.WriteLine("Engine is generating more power");
            Console.WriteLine("Now the ship is moving.. Wheeeee!");
        }
    }
}
