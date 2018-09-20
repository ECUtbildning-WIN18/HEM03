using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain2
{
    class Golfcart : Vehicle
    {
        public string Roof { get; set; }

        public Golfcart(string model, string licenseNumber, string engine, Person owner, Person driver, string roof)
            : base(model, licenseNumber, engine, owner, driver)
        {
            Roof = roof;
        }
        public void GiveGas(bool gas)
        {
            if (gas == true)
                Console.WriteLine("Supposed to speed up but nothing happens...");
            else
                Console.WriteLine("Crawling along");
        }
    }

}