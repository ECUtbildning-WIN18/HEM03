using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Galactica : Vehicle
    {
        public string Owner { get; }
        public string Engine { get; }

        public Galactica(string engine) : base("Battlestar", "Leet1337")
        {
            Engine = engine;
        }

        public void Power()
        {
            Console.WriteLine("Increase POWER!!");
        }

    }
}
