using System;

namespace HEM03.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            BattlestarGalactia BattlestarGalactia = new BattlestarGalactia("Spaceship", "AAA111",
                "Itwill Beme", "FTL", "William Adams");

            GolfCar AdamsGolfCar = new GolfCar("spaceGolf", "BAA111", "green",
                "Yamaha G19", "William Adams");

            AdamsGolfCar.PrintInfoAboutGolfCar();
            BattlestarGalactia.PrintInfoAboutBattlestarGalactia();

            BattlestarGalactia.Accelerate();
            AdamsGolfCar.Accelerate();            
        }
    }
}
