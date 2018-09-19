using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Domain
{
    class Ship : Vehicle
    {
        string CommanderFirstName { get; }
        string CommanderLastName { get; }
        string CommanderFavouriteColor { get; }

        public Ship(string serialnumber, bool powerswitch, string model, string regnumber, bool cupholder,
                                        string commanderFirstName, string commanderLastName,
                                        string commanderFavouriteColor)
                                      : base(serialnumber,powerswitch,model, regnumber, cupholder)
            // super long constructor here boss! Inheritance order: Engine -> Vehicle -> Ship
        {
            CommanderFirstName = commanderFirstName;
            CommanderLastName = commanderLastName;
            CommanderFavouriteColor = commanderFavouriteColor;
        }
    }
}
