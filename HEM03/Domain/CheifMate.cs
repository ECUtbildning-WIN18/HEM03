using System;

namespace HEM03.Domain
{
    class CheifMate : Person
    {
        public CheifMate(string firstName, string lastName, string favoritColor) : base (firstName, lastName, favoritColor)
        {
            Rank = "Cheif Mate";
        }

        public void Turning()
        {
            Console.WriteLine("The ship is turning");
        }
    }
}
