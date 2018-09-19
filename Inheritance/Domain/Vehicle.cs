using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Domain
{
    class Vehicle : Engine
    {
        string Model { get; }
        string RegistrationNumber { get; }
        bool CupHolder { get; }

        public Vehicle(string serialnumber, bool powerswitch, string model, string regnumber, bool cupholder)
                       : base(serialnumber, powerswitch)
        // Here we inherit serialnumber and powerswitch from the Engine Class
        {
            Model = model;
            RegistrationNumber = regnumber;
            CupHolder = cupholder;
            // Now our Vehicles are constructed with Engines!
        }
    }
}
