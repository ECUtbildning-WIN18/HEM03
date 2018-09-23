using HEM03.Domain;
using System;

namespace HEM03
{
    class Program
    {
        static void Main(string[] args)
        {
            ChiefMate chiefMate = new ChiefMate("Starbuck", "Moonson", "blue...ish");
            Commander commander = new Commander("Adama", "Starfish", "green");
            GolfCart golfCart = new GolfCart("EZGO TXT", "ABC123", "green...ish", commander, "SparcleEdition");
            Galactica galactica = new Galactica("Battlestar Galactica", "SUN999", "deep green", commander, true);

            commander.Comanding();
            chiefMate.Yelling();
            galactica.PrintVehicleData();
            Console.WriteLine();
            Console.WriteLine($"Speed: {galactica.Speed}");
            galactica.Accelerate();
            Console.WriteLine($"Speed: {galactica.Speed}");
            galactica.Brake();
            Console.WriteLine($"Speed: {galactica.Speed}");
            galactica.Brake();
            Console.WriteLine($"Speed: {galactica.Speed}");
            galactica.Brake();
            Console.WriteLine($"Speed: {galactica.Speed}");
            galactica.Accelerate();
            Console.WriteLine($"Speed: {galactica.Speed}");
            Console.WriteLine();
            golfCart.PrintVehicleData();
            Console.WriteLine($"Speed: {golfCart.Speed}");
            golfCart.Accelerate();
            Console.WriteLine($"Speed: {golfCart.Speed}");
            golfCart.Brake();
            Console.WriteLine($"Speed: {golfCart.Speed}");
            Console.ReadKey();
        }
    }
}
