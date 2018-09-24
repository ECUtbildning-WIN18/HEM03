using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Engine
    {
        public string Model { get; set; }
        public int SerialNumber { get; set; }
        public string Type { get; set; }

        public Engine(string model, int serialNumber, string type)
        {
            Model = model;
            SerialNumber = serialNumber;
            Type = type;
        }


    }
}
