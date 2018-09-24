using System;
using Inheritance.Domain;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Commander = new Person("Luke","Skywalker","Blue");
            Engine XwingEngine = new Engine("12345",false);
            Ship LukesXwing = new Ship("Luke Skywalker", "X-Wing", "901109", true, Commander, XwingEngine);
            LukesXwing.StartEngine();   // Starts the Ships engine, now we can Accelerate!
            LukesXwing.Accelerate();   // 
            Console.ReadLine();
            Engine GolfCartEngine = new Engine("54321", false);
            GolfCart EpicGolfCart = new GolfCart("Darth Vader","GG.GolfuKartu","66",true, GolfCartEngine);
            EpicGolfCart.StartEngine(); // Same as above
            EpicGolfCart.Accelerate();
            Console.ReadLine();
        }
    }
}
