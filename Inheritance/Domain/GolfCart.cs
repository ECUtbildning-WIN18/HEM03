using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Domain
{
    class GolfCart : Engine
    {
        public GolfCart(string owner, string model, string regnumber, bool cupholder, string serialnumber, bool powerswitch)
                                      : base(owner, model, regnumber, cupholder, serialnumber, powerswitch)
        // super long constructor here boss! Inheritance order: Vehicle -> Engine ->GolfcarT
        {

        }
    }
}
