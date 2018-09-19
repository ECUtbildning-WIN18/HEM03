using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Ship : Vehicle
    {

        public Ship(string model, string registrationNumber, EngineTypes engineType) : base(model, registrationNumber, engineType)
        {

        }
        //gets and sets
        public override string GetVehicleType()
        {
            return "Ship";
        }

    }
}
