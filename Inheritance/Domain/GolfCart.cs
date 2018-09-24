using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Domain
{
    class GolfCart : Vehicle
    {
        Engine Engine { get; } = new Engine("2134", false);

        public GolfCart(string owner, string model, string regnumber, bool cupholder, Engine engine)
                                      : base(owner, model, regnumber, cupholder)
        // Now Golfcart is a Vehicle that has an engine
        {
            engine = Engine;
        }

        public void Accelerate()
        {
            Engine.Accelerate();
        }

        public void StartEngine()
        {
            Engine.PowerOn();
        }

        public void TurnOffEngine()
        {
            Engine.PowerOff();
        }
    }
}
