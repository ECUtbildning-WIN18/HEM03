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
                Console.WriteLine("The engine will accelerate and you will now raise your speed. " +
                    "Call your mum and tell her that you love her." +
                    " This speed is very fast and you may die...");
        }
        
    }
    
}
