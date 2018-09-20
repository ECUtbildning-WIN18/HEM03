using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class GolfCart : Vehicle 
    {
        private string Color { get; }

        public GolfCart(string color) : base("Raptor junior", "ABC123", "Yamaha G19", "William Adaman")
        {
            Color = color;
        }

        public override void Drive()
        {
            Console.WriteLine("Golfcart increasing speed");
            Console.WriteLine("WHOOOM!!!");
        }
    }
}
