using HEM03.Domain;
using System;

namespace HEM03
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship myShip = new Ship("Battlestar Galactica", "123ABC", new Person("Adama", "Green"), new Person("Alexander", "lila"), new Engine("FTL "));
            Golfcart myCart = new Golfcart("Tesla Model 3", "ABC123", new Person("Adama", "Green"),  new Engine("Yamaha G19"));

            Console.WriteLine($"Registration number: {myCart.RegistratioNumber}");
            Console.WriteLine($"Model: {myCart.Model}");
            Console.WriteLine($"Owner: {myCart.Person.FirstName}");
            Console.WriteLine($"Styrman: {myShip.Styrman.FirstName}");

            myCart.Engine.Gas();
            myShip.Engine.Gas();

        }
    }
}
