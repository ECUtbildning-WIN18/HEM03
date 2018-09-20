using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    abstract class Vehicle
    {
        public string Model { get; }
        public string RegistrationNumber { get;  }
        public string Engine { get; }
        public string Owner { get; }

        public Vehicle(string model, string registrationNumber, string engine, string owner)
        {
            Model = model;
            RegistrationNumber = registrationNumber;
            Engine = engine;
            Owner = owner;
        }

        public abstract void Drive();
    }
}
