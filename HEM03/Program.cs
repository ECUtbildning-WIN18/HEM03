using HEM03.Domain;
using System;

namespace HEM03
{
    class Program
    {
        static void Main(string[] args)
        {

            Galactica Galactica = new Galactica("Adama", "FTL");

            Console.WriteLine(Galactica.Model + " " + Galactica.Owner + " " + Galactica.RegistrationNumber);

            Galactica.Power();


            GolfCar GolfCar = new GolfCar("Adama", "Yamaha G19");

            Console.WriteLine(GolfCar.Model + " " + GolfCar.RegistrationNumber);

            GolfCar.Power();

        }
    }
}
