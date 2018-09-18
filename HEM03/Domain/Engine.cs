using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Engine
    {
        public string EngineType { get;  }

        public Engine (string engineType)
        {
            EngineType = engineType;
        }

        public void RaiseSpeed()
        {

            Console.WriteLine("You will now raise your speed. If you are in your spaceship, " +
                "call your mum and tell her that you love her. This speed is very fast and you may die..." +
                "If you are in your GolfCar, just sitt back and enyoy the ride");

     
                

        }
    }
    
}
