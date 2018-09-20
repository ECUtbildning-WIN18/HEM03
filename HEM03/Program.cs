using System;
using System.Collections.Generic;
//using HEM03.Domain;
using HEM03.Domain2;

namespace HEM03
{
    class Program
    {
        static void Main(string[] args)
        {
            Person adama = new Person("Cdr", "Adama");
            Person buck = new Person("1st mate", "Buck Rogers");

            Battleship battlestarGalactica = new Battleship("BS", "123-456", "FTL", adama, adama, "Megablaster");
            Golfcart buggy = new Golfcart("Satan-Truck", "456-789", "Yamaha G19", adama, buck, "Tiled Roof");

            //List<Vehicle> fleet = new List(BattlestarGalactica, buggy);
            //Har försökt att skapa en lista (fleet) av objekt för att kunna hantera dem kollektivt men inte lyckats.

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