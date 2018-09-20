using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Commander : Person
    {
        public string Rank { get; } = "Chief Mate";

        public Commander(string firstName, string lastName, string color)
            : base(firstName, lastName, color)
        {
        }

        public void Comanding()
        {
            Console.WriteLine("Next destination is...blablaBLA!");
        }
    }
}
