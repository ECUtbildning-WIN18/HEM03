using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Galactica : Vehicle
    {
        public string Owner { get; }
        public string Engine { get; }
        

        public Galactica(string owner, string engine) : base("Battlestar", "Leet1337")
        {
            Engine = engine;
            Owner = owner;
        }

        public void Power()
        {
            Console.WriteLine("Increase POWER!!");
        }

    }
}
