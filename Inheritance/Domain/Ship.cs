using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Domain
{
    class Ship : Engine
    {
        public Person Commander { get; }

        public Ship(string owner, string model, string regnumber, bool cupholder, string serialnumber, bool powerswitch,
                                        Person commander)
                                      : base(owner, model, regnumber, cupholder, serialnumber, powerswitch)
            // super long constructor here boss! Inheritance order: Vehicle -> Engine -> Ship
        {
            commander = Commander; // We have to make a person first and put him/her in the Constructor
        }
    }
}
