using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class PowerLoader : Vehicle
    {
        public int LiftCapacity { get; }

        public PowerLoader(string model, string registrationNumber, int liftCapacity) :
        base(model, registrationNumber)
        {
            LiftCapacity = liftCapacity;
        }

    }
}
