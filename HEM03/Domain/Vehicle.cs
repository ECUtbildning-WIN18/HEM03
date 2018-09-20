using System;

namespace HEM03.Domain
{
    class Vehicle
    {
        public string Brand { get; protected set; }
        public int Registration { get; protected set; }
        public bool CupHolder { get; protected set; }
        public Engine Engine { get; protected set; }
        public Commander Commander{ get; protected set; }
        public string Color { get; }

        public Vehicle(string brand, int registration, bool cupHolder, Engine engine, Commander commander, string color)
        {
            Brand = brand;
            Registration = registration;
            CupHolder = cupHolder;
            Engine = engine;
            Commander = commander;
            Color = color;
        }

        public virtual void ParkTheVehicle()
        {
            Console.WriteLine("You park the Vehicle gently");
        }
    }
}
