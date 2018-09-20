using System;
namespace Inheritance.Domain
{
    class Engine : Vehicle
    {
         private string SerialNumber { get; }
         private bool PowerSwitch { get; set; } // Represents a Button True means its on and False means its off

        public Engine(string owner, string model, string regnumber, bool cupholder,string serialNumber, bool powerSwitch)
               : base(owner, model, regnumber, cupholder)
        {   
            SerialNumber = serialNumber;
            PowerSwitch = powerSwitch;
        }
        public void EnginePowerOn()
        {
            PowerSwitch = true;
            Console.WriteLine("Engine is on!");
        }
        public void EnginePowerOff()
        {
            PowerSwitch = false;
            Console.WriteLine("Engine is off!");
        }
        public void Accelerate()
        {
            if (PowerSwitch == true){ 
            Console.WriteLine("We're Accelerating!");
            }
            else if (PowerSwitch == false){ 
            Console.WriteLine("Power Offline");
            }
        }
    }
}
