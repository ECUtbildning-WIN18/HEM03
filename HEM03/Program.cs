using HEM03.Domain;
using System;

namespace HEM03
{
    class Program
    {
        static void Main(string[] args)
        {

            ChiefMate chiefMate = new ChiefMate("Starbuck", "Moonson", "blue...ish");
            Commander commander = new Commander("Adama", "Starfish", "green");

            GolfCart golfCart = new GolfCart("EZGO TXT", "ABC123", "green...ish", commander, "SparcleEdition");
            Galactica galactica = new Galactica("Battlestar Galactica", "SUN999", "deep green", commander, true);

            commander.Comanding();
            chiefMate.Yelling();

            Console.WriteLine(galactica.Speed);
            galactica.Accelerate();
            Console.WriteLine(galactica.Speed);
            galactica.Brake();
            Console.WriteLine(galactica.Speed);

            /*... more to come...*/

            Console.ReadKey();
        }
    }
}
