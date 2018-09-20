using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Car : Vehicle
    {
        public int Doors { get; }

        public Car(string model, string registrationNumber, int doors) :
        base(model, registrationNumber)
        {
            Doors = doors;
        }

    }
}
