using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Person
    {
        private string FirstName { get; }
        private string LastName { get; }
        private string Rank { get; }

        public Person(string firstName, string lastName, string rank)
        {
            FirstName = firstName;
            LastName = lastName;
            Rank = rank;
        }
    }
}
