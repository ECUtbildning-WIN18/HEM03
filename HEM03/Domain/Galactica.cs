using System;

namespace HEM03.Domain
{
    class Galactica : Vehicle 

    {
        public CheifMate CheifMate { get; }

        public Galactica(string brand, int registration, bool cupHolder, Engine engine, Commander commander, CheifMate cheifMate, string color) : base(brand, registration, cupHolder, engine, commander, color)
        {
            CheifMate = cheifMate;
        }

        public override void ParkTheVehicle()
        {
            Console.WriteLine("Are you crazy! You can´t park that!");
        }
    }
}
