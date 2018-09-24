using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    abstract class Vehicle
    {
        
        public string RegNumber { get; }
        public string Brand { get; }
        public string Color { get; set; }
        public Owner Owner { get; set; }
        public Engine Engine { get;}
        

        protected Vehicle(string regNumber, string brand, string color,
            Owner owner, Engine engine)
        {
            RegNumber = regNumber;
            Brand = brand;
            Color = color;
            Owner = owner;
            Engine = engine;
        }
        
    }
}
