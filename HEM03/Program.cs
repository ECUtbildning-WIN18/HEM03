using HEM03.Domain;
using System;

namespace HEM03
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Tesla Model 3", "ABC123", 4);

            Console.WriteLine($"Registration number: {myCar.RegistrationNumber}");

            Console.WriteLine($"Model: {myCar.Model}");

            Console.WriteLine($"Number of doors: {myCar.Doors}");

        }
    }
}
