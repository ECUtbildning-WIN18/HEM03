using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain2
{
    class Battleship : Vehicle
    {
        public string Cannon { get; }

        public Battleship(string model, string licenseNumber, string engine, Person owner, Person driver, string cannon)
            : base("BS", "123-456", engine, owner, driver)
        {
            Cannon = cannon;
        }
        public void GiveGas(bool gas)
            
        {
            if (gas)
            {
                Console.WriteLine("Speeds up!");
            }
            else
            {
                Console.WriteLine("Cruising along.");
            } 
        }
    }
}