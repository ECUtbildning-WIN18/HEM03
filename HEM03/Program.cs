using System;
using System.Collections.Generic;
using HEM03.Domain;

namespace HEM03
{
    class Program
    {
        


        static void Main(string[] args)
        {


            Vehicle[] fleet = new Vehicle[2];

            Owner Own1 = new Owner("Adama", "Adama", "Commander");

            Engine Golfcarengine = new Engine("Yamaha", 112, "G19");

            Engine Battleshipengine = new Engine("FTL", 888, "Atom");

            //Battleship battleship = new Battleship("ABC123", "BS-FTL", "Green",
            //    Own1, Battleshipengine);

            //GolfCar golfCar = new GolfCar("BCA123", "Yamaha", "Green",
            //    Own1, Golfcarengine);

            Vehicle golfcar = new GolfCar("BCA123", "Yamaha", "Green",
                Own1, Golfcarengine);

            Vehicle battleship = new Battleship("ABC123", "BS-FTL", "Green",
              Own1, Battleshipengine);
            


            fleet[0] = battleship;
            fleet[1] = golfcar;


            foreach (var vehicle in fleet)
            {
                vehicle.Test();
            }


            

            //Engine Golfcarengine = new Engine("Yamaha", 112, "G19");

            //Engine Battleshipengine = new Engine("FTL", 888, "Atom");


            //Battleship battleship = new Battleship("ABC123", "BS-FTL", "Green",
            //    Own1, Battleshipengine);

            //GolfCar golfCar = new GolfCar("BCA123", "Yamaha", "Green",
            //    Own1, Golfcarengine);


            //battleship.Acceleration();

            //golfCar.Acceleration();


            Console.ReadLine();




        }
    }

}
