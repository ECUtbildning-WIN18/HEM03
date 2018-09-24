using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Domain
{
    class Ship : Vehicle
    {
        public Person Commander { get; }
        Engine Engine { get; } = new Engine("2134", false); // set values here because we dont want a null return

        public Ship(string owner, string model, string regnumber, bool cupholder,
                                        Person commander, Engine engine)
                                      : base(owner, model, regnumber, cupholder)
        {
            commander = Commander; // We have to make a person first and put him/her in the Constructor
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
