using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class GolfCar : Vehicle
    {

        public GolfCar(string regNumber, Person owner) : base(regNumber, "Yamaha", owner, new Engine(10, "Yamaha G19"))
        {
            
        }
    }
}
