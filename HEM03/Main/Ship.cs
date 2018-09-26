using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Main
{
    class Ship : Vehicle
    {
        public Ship(string model, string registrationNumber, string motor, string styrman)
            : base(model, registrationNumber, motor)


        {
            Model = model;
            RegistrationNumber = registrationNumber;
            Motor = motor;
            Styrman = styrman;
        }

    }
}
