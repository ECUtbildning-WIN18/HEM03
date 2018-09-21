using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class PowerLoader : Vehicle
    {
        public int LiftCapacity { get; }

        public PowerLoader(string model, string registratioNumber, Engine engine, int liftCapacity) :
            base(model, registratioNumber, engine)
        {
            LiftCapacity = liftCapacity;
        }
    }
}
