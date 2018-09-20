using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class BattelStar:Vehicle
    {
        public string Owner;
        public string Enginetype { get; set; }

        public BattelStar(string model, int registrationNumber,string owner, string engineType)
            : base(model, registrationNumber)
        {
            Enginetype = engineType;
            Owner = owner;
        }
        public void Accelerate()
        {
            Console.WriteLine(" Increased the speed of Ship");
        }


    }
}
