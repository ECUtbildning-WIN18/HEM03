using System;
namespace Inheritance.Domain
{
    class Engine 
    {
      private string SerialNumber { get; }
      private bool IsEngineOn { get; set; }

      public Engine(string serialNumber, bool isEngineOn)
               
      {   
      SerialNumber = serialNumber;
      IsEngineOn = isEngineOn;
      }

        public void PowerOn()
        {
        IsEngineOn = true;
        Console.WriteLine("Engine is on!");
        }

        public void PowerOff()
        {
        IsEngineOn = false;
        Console.WriteLine("Engine is off!");
        }

        public void Accelerate()
        {
         if (IsEngineOn == true){ 
         Console.WriteLine("We're Accelerating!");
         }
         else if (IsEngineOn == false){ 
         Console.WriteLine("Power Offline");
         }
        }
    }
}
