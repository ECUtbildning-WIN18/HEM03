using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Car : Vehicle
    {
        public int Doors { get; }

        public Car(string model, string registratioNumber, Engine engine, int doors) :
            base(model, registratioNumber, engine)
        {
            Doors = doors;
        }
    }
}
