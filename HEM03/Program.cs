using System;

namespace HEM03
{
    using HEM03.Main;

    class Program
    {
        static void Main(string[] args)
        {
            Company myCompany = new Company("Galactica", "Adam", "Green", "Stryman");

            Console.WriteLine($"Company name: {myCompany.Name}");
            Console.WriteLine($"Owner: {myCompany.Owner}");
            Console.WriteLine($"Owners favorite color: {myCompany.FavoritColor}");
            Console.WriteLine($"Employee: {myCompany.Employee}");

            Golfcar myGolfcar = new Golfcar("Volvo Model 10", "MNC890", "Yamaha G19", 4);

            Console.WriteLine("Golfcar description:");
            Console.WriteLine($"Model: {myGolfcar.Model}");
            Console.WriteLine($"Registration number: {myGolfcar.RegistrationNumber}");
            Console.WriteLine($"Motor: {myGolfcar.Motor}");
            Console.WriteLine($"Number of doors: {myGolfcar.Doors}");



            Ship myShip = new Ship("Audi Model 22", "PBH 219", "FTL", "Svensson");

            Console.WriteLine("Ship description:");
            Console.WriteLine($"Model: {myShip.Model}");
            Console.WriteLine($"Registration number: {myShip.RegistrationNumber}");
            Console.WriteLine($"Motor: {myShip.Motor}");
            Console.WriteLine($"Styrman: {myShip.Styrman}");

            myShip.GettOrder();
            

            Console.ReadLine();
           }
    }
}
