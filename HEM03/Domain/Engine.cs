using System;

namespace HEM03.Domain
{
    class Engine
    {
        public int SerialNumber { get; }
        public int EnginePower { get; protected set; }
        public bool HasFasterThenLightEngine { get; }
        public string TypeOfEngine { get; }

        public Engine(int serialNumber, bool hasFasterThenLightEngine, string typeOfEngine)
        {
            EnginePower = 0;
            SerialNumber = serialNumber;
            HasFasterThenLightEngine = hasFasterThenLightEngine;
            TypeOfEngine = typeOfEngine;
        }

        public void Accelerate()
        {
            if (EnginePower < int.MaxValue - 10)
            EnginePower += 10;
        }

        public void Brake()
        {
            EnginePower -= 10;
        }

        public void FasterThenLightSpeed()
        {
            if(HasFasterThenLightEngine)
            {
                EnginePower = int.MaxValue;
                Console.WriteLine($"We will go Kessel Run in less than twelve parsecs. The power is now {EnginePower}");
            }
            
            
        }
        
    }
}
