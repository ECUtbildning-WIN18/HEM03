using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class GolfCar : Vehicle
    {
        public Yamaha Yamaha { get; }

        public GolfCar(string regNumber, Person owner, Yamaha yamaha) : base(regNumber, "Yamaha G19", owner, yamaha)
        {
            Yamaha = yamaha; 
        }
    }
}
