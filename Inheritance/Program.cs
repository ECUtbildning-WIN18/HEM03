using System;
using Inheritance.Domain;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Commander = new Person("Luke","Skywalker","Blue");
            Ship LukesXwing = new Ship("Luke Skywalker", "X-Wing", "901109", true, "12345", false, Commander);
            LukesXwing.EnginePowerOn();           // Turns on the Ships Engine
            LukesXwing.Accelerate();             // And it can tell its engine to Accelerate ( Engine needs to be on for this :p)
            Console.ReadLine();                  // even though they are methods of a different Class!
            GolfCart VadersGolfCart = new GolfCart("Darth Vader","TheTradgedyOfDarthPlageusTheWise123","66",true,"661", false);
            VadersGolfCart.EnginePowerOn(); // Same as above
            VadersGolfCart.Accelerate();
            Console.ReadLine();
        }
    }
}
