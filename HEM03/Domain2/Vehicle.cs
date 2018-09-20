using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain2
{
    class Vehicle
    {
        public string Model { get; }
        public string LicenseNumber { get; }
        public string Engine { get; }
        public Person Owner { get; set; }
        public Person Driver { get; set; }

        public Vehicle(string model, string licenseNumber, string engine, Person owner, Person driver)
        {
            Model = model;
            LicenseNumber = licenseNumber;
            Engine = engine;
            Owner = owner;
            Driver = driver;
        }
        //public void GiveGas(bool gas)
        // {
        //     if (gas == true)
        //         Console.WriteLine("Speeeeeeeeeeeeeeeeed !!!!");
        //     else
        //         Console.WriteLine("Steady pace.");
        // }
    }

}