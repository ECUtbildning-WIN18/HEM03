using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Domain
{
    class GolfCar : Vehicle
    {
        string Owner { get; }
        public GolfCar(string serialnumber, bool powerswitch, string model, string regnumber, bool cupholder, string owner)
                                            : base(serialnumber,powerswitch,model, regnumber, cupholder)
        // super long constructor here boss! Inheritance order: Engine -> Vehicle -> Ship
        {
            Owner = owner;
        }
    }
}
