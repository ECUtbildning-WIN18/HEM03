using System;
using HEM03.Domain2;

namespace HEM03
{
    class Program
    {
        static void Main(string[] args)
        {
            Person adama = new Person("Cdr", "Adama");
            Person buck = new Person("1st mate", "Buck Rogers");
            Battleship battlestarGalactica = new Battleship("B-ship", "123-456", "FTL", adama, adama, "Megablaster");
            Golfcart buggy = new Golfcart("Honka-truck", "456-789", "Yamaha G17", adama, buck, "Tiled roof" );

            Console.WriteLine($"Model: {battlestarGalactica.Model}");
            Console.WriteLine($"License number: {battlestarGalactica.LicenseNumber}");
            Console.WriteLine($"Propulsion unit: {battlestarGalactica.Engine}");
            battlestarGalactica.GiveGas(false);
            Console.WriteLine("");
            Console.WriteLine($"Model: {buggy.Model}");
            Console.WriteLine($"License number: {buggy.LicenseNumber}");
            Console.WriteLine($"Propulsion unit: {buggy.Engine}");
            buggy.GiveGas(true);
        }
    }
}