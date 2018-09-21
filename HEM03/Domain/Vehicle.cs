using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Vehicle
    {
        public string Model { get; }
        public string RegistratioNumber { get; }
        public Engine Engine { get; }       

        public Vehicle(string model,string registratioNumber, Engine engine)            
        {
            Model = model;
            RegistratioNumber = registratioNumber;
            Engine = engine;
        }        
    }
}
