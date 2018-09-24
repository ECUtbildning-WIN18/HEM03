using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Vehicle
    {
        public string RegNumber { get; }
        public string Model { get; }
        public Person Owner { get; }
        private Engine Engine { get; }

        public Vehicle(string regNumber, string model, Person owner, Engine engine)
        {
            RegNumber = regNumber;
            Model = model;
            Owner = owner;
            Engine = engine;
        }

        //kommer åt Engine.output för att det är deklarerat i Engine-klassen.
        public void Accelerate()
        {
            Engine.IncreaseOutput();
        }
    }
}
