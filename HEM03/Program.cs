using System;
using HEM03.Domain;

namespace HEM03
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner p1 = new Owner("Adama", "Adama", "befälhavare"); 
            Engine Golfcarengine = new Engine("Yamaha", 112, "G19");
            Engine Battleshipengine = new Engine("FTL", 888, "Atom");

            Battleship battleship = new Battleship("ABC123", "BS-FTL", "Green",
                p1, Battleshipengine);
            GolfCar golfCar = new GolfCar("BCA123", "Yamaha", "Green",
                p1, Golfcarengine);


            battleship.Acceleration();

            golfCar.Acceleration();



            Console.ReadLine();



        }
    }

}
