using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class ChiefMate : Person
    {
        public string Rank { get; } = "Chief Mate";

        public ChiefMate (string firstName, string lastName, string color) 
            : base (firstName, lastName, color)
        {
        }

        public void Yelling()
        {
            Console.WriteLine("AAAARGH....!");
        }

    }    
}
