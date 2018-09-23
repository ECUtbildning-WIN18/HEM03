using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Color { get; }

        public Person(string firstName, string lastName, string color)
        {
            FirstName = firstName;
            LastName = lastName;
            Color = color;
        }     
    }   
}
