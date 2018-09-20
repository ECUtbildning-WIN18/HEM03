using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class GolfCar
    {
        public string Engine { get; set; }
        public int RegNumber { get; set; }
        public string Model { get; set; }
        

        public GolfCar(string engine, int regNumber, string model)
        {
            Engine = engine;
            RegNumber = regNumber;
            Model = model;
           
        }



    }
}
