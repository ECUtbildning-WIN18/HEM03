using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Main
{
    class Vehicle
    {
        public string Model { get; set; }

        public string RegistrationNumber { get; set; }

        public string Motor { get; set; }

        public string Styrman { get; set; }

        public Vehicle(string model, string registrationNumber, string motor, string styrman)
        {
            Model = model;
            RegistrationNumber = registrationNumber;
            Motor = motor;
        }

        public Vehicle(string model, string registrationNumber, string motor)
        {
            Model = model;
            RegistrationNumber = registrationNumber;
            Motor = motor;
        }

        public void GettOrder()

        {
            Console.WriteLine("Give your order: ");

            string myorder = Console.ReadLine();

            if (myorder == "Gas")
            {
                Console.WriteLine("Ship! Accelerate!");
                Console.WriteLine("Golfcar! Accelerate!");
            }
            else
            
                Console.WriteLine("OK");
            

        }

    }
}
