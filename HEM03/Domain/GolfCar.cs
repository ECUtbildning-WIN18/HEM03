using System;

namespace HEM03.Domain
{
    class GolfCar : SpaceVehicle
    {

        public string GolfCarColor { get; }
        private OwnerOfSpaceVehicles Owner;
        private Engine Engine;

        public GolfCar(string model, string registrationNumber,
            string golfCarColor, Engine engineType, OwnerOfSpaceVehicles owner)
            : base(model, registrationNumber)
        {
            GolfCarColor = golfCarColor;
            this.Owner = owner;
            this.Engine = engineType;


        }

        public void GetInfoAboutGolfCar()
        {
            Console.WriteLine("This is info about the GolfCar: ");
            Console.WriteLine("Owner: " + Owner.Owner);
            Console.WriteLine("Colour: " + GolfCarColor);
            Console.WriteLine("Registration number: " + RegistrationNumber);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Engine type: " + Engine.EngineType);
            Console.WriteLine(" ");
        }
    }
}
