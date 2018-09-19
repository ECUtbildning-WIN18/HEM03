using System;


namespace HEM03.Domain
{
    class Engine
    {
        public string EngineType { get;  }

        public Engine (string engineType)
        {
            EngineType = engineType;
        }

        public void RaiseSpeed() //raise engine speed
        {
            Console.WriteLine("The engine is now working at full power");
        }

    }
    
}
