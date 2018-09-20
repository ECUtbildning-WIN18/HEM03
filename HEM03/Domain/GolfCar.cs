using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class GolfCar : Vehicle
    {

        string Owner { get; }
        string Engine { get; }

        public GolfCar(string owner, string engine) : base("Golf Car", "ABC123")
        {
            Owner = owner;
            Engine = engine;
        }

        public void Power()
        {
            Console.WriteLine("Incease power!");
        }
        

    }
}
