using System;

namespace HEM03.Domain
{
    class GolfCar : Vehicle
    {
        public string Color { get; set; }
     
        public GolfCar(string model, string registrationNumber,
            string color, string engineType, string owner)
            : base(model, registrationNumber, engineType, owner)
        {
            Color=color;
        }

        public void PrintInfoAboutGolfCar() 
        {
            Console.WriteLine("====This is info about the GolfCar==== ");
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine($"Colour: {Color}");
            Console.WriteLine($"Registration number: {RegistrationNumber}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Engine type: {EngineType}");
            Console.WriteLine(" ");
        }


        public override void Accelerate() 
        {
            Console.WriteLine(" The Golfcar will now accelerate! Sit back and enjoy. Remember the speed limit, but in a golfcar" +
                " this might not be a problem...!");
        }
    }
}
