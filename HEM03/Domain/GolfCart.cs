using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class GolfCart : Vehicle
    {
        public GolfCart(string model, string registrationNumber, EngineTypes engineType) : base(model, registrationNumber, engineType)
        {
        }

        public override string GetVehicleType()
        {
            return "Golf cart";
        }
    }
}
