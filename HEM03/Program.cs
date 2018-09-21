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

            Engine ftl = new Engine(0, "FTL");
            Engine yamaha = new Engine(0, "Yamaha G19");

            SpaceShip Galactica = new SpaceShip(kara, "MG6000", adama);
            GolfCar GolfCar = new GolfCar("UHY977", adama);
            

        }
    }
}
