using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Domain
{
    class Person
    {
        private string FirstName { get; }
        private string LastName { get; }
        private string FavouriteColor { get; }

        public Person(string firstName, string lastName, string favouriteColor)
        {
            FirstName = firstName;
            LastName = lastName;
            FavouriteColor = favouriteColor;
        }
    }
}
