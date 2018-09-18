using System;

namespace HEM03.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            OwnerOfSpaceVehicles Owner = new OwnerOfSpaceVehicles("William Adams");
            Engine BSGEngine = new Engine("FTL (Faster than light)");
            Engine GolfCarEngine = new Engine("Yamaha G19");

            BattlestarGalactia BattlestarGalactia = new BattlestarGalactia("Spaceship", "AAA111",
                "Itwill Beme", BSGEngine, Owner);
            GolfCar AdamsGolfCar = new GolfCar("spaceGolf", "BAA111", "green",
                GolfCarEngine, Owner);

            Console.WriteLine("This is info about the GolfCar: ");
            Console.WriteLine("Owner: " + Owner.Owner);
            Console.WriteLine("Colour: " + AdamsGolfCar.GolfCarColor);
            Console.WriteLine("Registration number: " + AdamsGolfCar.RegistrationNumber);
            Console.WriteLine("Model: " + AdamsGolfCar.Model);
            Console.WriteLine("Engine type: " + GolfCarEngine.EngineType);

            //BSGEngine.RaiseSpeed();
            GolfCarEngine.RaiseSpeed();


            Console.ReadKey();
        }
    }
}
