using System;

namespace HEM03.Domain
{
    class Vehicle
    {
        public string Model { get; }
        
        public string RegistrationNumber { get; }

        public string EngineType { get; }

        public string Owner { get; }

        public Vehicle(string model, string registrationNumber, string engineType, string owner)
        {
            Model = model;
            RegistrationNumber = registrationNumber;
            EngineType = engineType;
            Owner = owner;
        }

        public virtual void Accelerate() 
        {
            Console.WriteLine("The engine is now working at full power");
        }

    }
}
