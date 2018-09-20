using HEM03.Domain;
using System;

namespace HEM03
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons Persons = new Persons("Adama", "Saul Tigh");

            Galactica Galactica = new Galactica("FTL");
            

            GolfCar GolfCar = new GolfCar("Yamaha G19", "Green");

            Console.WriteLine("Commander of Galactica: " + Persons.Commander);
            Console.WriteLine("2nd In command of Galactica: " + Persons.FirstMate);
            Console.WriteLine("Ship model: " + Galactica.Model +
                "\nShip registrationnumber: " + Galactica.RegistrationNumber +
                "\n\nThe toasters is coming! we need to increase power of Galactica");
            Galactica.Power();
            
            Console.WriteLine("\n\nSaul! Get my golfcar!. Its the " + GolfCar.Color + " " + "one");
            Console.WriteLine("push the " + GolfCar.Engine + " " + "i need it fast!");
            GolfCar.Power();

            

        }
    }
}
