using System;
using HEM03.Domain;

namespace HEM03
{
    class Program
    {
        static void Main(string[] args)
        {
            Commander theCommander = new Commander("Adama", "William", "Cylonsred");
            CheifMate theCheifMate = new CheifMate("John", "Doe", "Black");

            Engine ftl = new Engine(0001, true, "Faster than light dirve");
            Engine cbe = new Engine(0100, false, "Yamaha G19");

            Galactica galactica = new Galactica("Battlestar Galactica", 1978, true, ftl, theCommander, theCheifMate, "gray");
            GolfCart viper = new GolfCart("Slow Car", 1470, false, cbe, theCommander, "green");

            galactica.ParkTheVehicle();
            viper.ParkTheVehicle();
            theCommander.Drinking();
            theCheifMate.Turning();

            Console.WriteLine($"{galactica.Commander.FirstName} are the {galactica.Commander.Rank} of the {galactica.Brand}");
            Console.WriteLine($"{galactica.CheifMate.FirstName} are the {galactica.CheifMate.Rank} of the {galactica.Brand}");
            Console.ReadKey();
        }
    }
}
