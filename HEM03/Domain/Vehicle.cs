using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Vehicle
    {
        public string Model { get; protected set; }
        public string RegistrationNumber { get; protected set; }

        public Vehicle(string model, string registrationNumber)
        {
            Model = model;
            RegistrationNumber = registrationNumber;
        }
    }
}
