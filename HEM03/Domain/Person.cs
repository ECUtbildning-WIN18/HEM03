using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Person
    {
        public string FirstName { get; }
        public string FavoriteColour { get; }

        public Person(string firstName, string favoriteColour)
        {
            FirstName = firstName;
            FavoriteColour = favoriteColour;
        }
    }
}
