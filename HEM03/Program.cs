using HEM03.Domain;
using System;

namespace HEM03
{
    class Program
    {
        static void Main(string[] args)
        {
            Galactica galactica = new Galactica("William Adaman", "Captain Dude");
            GolfCart golfCart = new GolfCart("green");

            galactica.Drive();
            golfCart.Drive();

        }
    }
}
