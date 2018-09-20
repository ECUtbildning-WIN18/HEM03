using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Vehicle
    {
        public string Model { get; protected set; }
        public string RegistrationNumber { get; protected set; }
        public Engine Engine { get; protected set; }
        public string Color { get; }
        public Person Owner { get; }
        public int Speed { get; protected set; } = 0;

        public Vehicle(
            string model, 
            string registrationNumber, 
            string color, 
            Person owner
            )
        {
            Model = model;
            RegistrationNumber = registrationNumber;
            Color = color;
            Owner = owner;     
        }    
    }
}
