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
            Owner = owner;
            Engine = engineType;  
        }

        public void GetInfoAboutGolfCar() //info about golfcar
        {
            Console.WriteLine("This is info about the GolfCar: ");
            Console.WriteLine("Owner: " + Owner.Owner);
            Console.WriteLine("Colour: " + GolfCarColor);
            Console.WriteLine("Registration number: " + RegistrationNumber);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Engine type: " + Engine.EngineType);
            Console.WriteLine(" ");
        }


        public void Accelerate() //increase engine speed and prompt the passenger
        {
            Engine.RaiseSpeed();
            Console.WriteLine("Sit back and enjoy. Remember the speed limit, but in a golfcar" +
                " this might not be a problem...!");
        }
    }
}
