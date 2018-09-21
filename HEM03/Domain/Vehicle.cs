using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Vehicle
    {
        private string RegNumber { get; }
        private string Model { get; }
        private Person Owner { get; }
        private Engine Engine { get; }

        public Vehicle(string regNumber, string model, Person owner, Engine engine)
        {
            RegNumber = regNumber;
            Model = model;
            Owner = owner;
            Engine = engine;
        }
    }
}
