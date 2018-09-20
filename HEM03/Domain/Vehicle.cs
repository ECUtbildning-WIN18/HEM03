using System;
using System.Collections.Generic;
using System.Text;
using HEM03.Domain;

namespace HEM03.Domain
{
    class Vehicle
    {
        public string Model { get; }
        public string RegistrationNumber { get; }
        //public Person Driver { get; }

        public Vehicle(string model, string registrationNumber)
        {
            Model = model;
            RegistrationNumber = registrationNumber;
        }
        public void StartEngine()
        {
            Console.WriteLine("Starting engine.");
        }
        public void Drive()
        {
            Console.WriteLine("DRIVE GODDAMMIT!!");
        }
    }
}