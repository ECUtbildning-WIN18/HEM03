using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class GolfCar : Vehicle
    {
        
        public string Engine { get; }
        public string Color { get; }

        public GolfCar(string engine, string color) : base("Golf Car", "ABC123")
        {
            Engine = engine;
            Color = color;
        }

        public void Power()
        {
            Console.WriteLine("Incease power!");
        }
        

    }
}
