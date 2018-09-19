using System;
using Inheritance.Domain;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship MyTestShip = new Ship("E:987654",false,"X-Wing Fighter","9001010",true,"Luke","Skywalker","Blue" );
            MyTestShip.EngineSwitchMode(); // The ship can tell its engine to turn on or off
            MyTestShip.Accelerate();       // And it can tell its engine to Accelerate
            Console.ReadLine();            // even though they are methods of a different Class!
            GolfCar MyEpicGolfCar = new GolfCar("GC:912345",false, "EpicGolfCar", "987654",true,"Admiral Akbar");
            MyEpicGolfCar.EngineSwitchMode(); // Same as above
            MyEpicGolfCar.Accelerate();
            Console.ReadLine();
        }
    }
}
