using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain2
{
    class Battleship : Vehicle
    {
        public string Cannon { get; set; }

        public Battleship(string model, string licenseNumber, string engine, Person owner, Person driver, string cannon)
            : base(model, licenseNumber, engine, owner, driver)
        {
            Cannon = cannon;
        }
        public void GiveGas(bool gas)
        {
            if (gas == true)
                Console.WriteLine("Speeds up!");
            else
                Console.WriteLine("Keeps steady pace.");
        }
    }
}