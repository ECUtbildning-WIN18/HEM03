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

            AdamsGolfCar.GetInfoAboutGolfCar();
            BattlestarGalactia.GetInfoAboutBattlestarGalactica();


            BattlestarGalactia.Accelerate();
            AdamsGolfCar.Accelerate();
                      
            Console.ReadKey();
        }
    }
}
