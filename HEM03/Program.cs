using HEM03.Domain;
using System;

namespace HEM03
{
    class Program
    {
        static void Main(string[] args)
        {
            Person adama = new Person("William", "Adama", "Commander");
            Person kara = new Person("Kara", "Thrace", "Lieutenant");

            FTL ftl = new FTL();
            Yamaha yamaha = new Yamaha();

            SpaceShip Galactica = new SpaceShip(kara, "MG6000", adama, ftl);
            GolfCar GolfCar = new GolfCar("UHY977", adama, yamaha);

            Console.WriteLine(GolfCar.Model);

            Galactica.Accelerate();
            GolfCar.Accelerate();

            Console.WriteLine(GolfCar.Speed.ToString() + "  " + Galactica.Speed.ToString());

        }
    }
}
