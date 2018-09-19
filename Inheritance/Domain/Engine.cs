using System;
namespace Inheritance.Domain
{
    class Engine
    {
         string SerialNumber { get; }
         bool PowerSwitch { get; set; } // Represents a Button True means its on and False means its off

        public Engine(string serialNumber, bool powerSwitch)
        {
            SerialNumber = serialNumber;
            PowerSwitch = powerSwitch;
        }

        public void EngineSwitchMode() 
        {
            if (PowerSwitch == false)
            {
                PowerSwitch = true;
                Console.WriteLine("Engine is on!");
            }
            else if (PowerSwitch == true)
            {
                PowerSwitch = false;
                Console.WriteLine("Engine is off!");
            }
        }


        public void Accelerate()
        {
            if (PowerSwitch == true)
            Console.WriteLine("We're Accelerating!");
            else if (PowerSwitch == false)
            Console.WriteLine("Power Offline");
        }
    }
}
