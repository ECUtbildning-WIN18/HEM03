using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Color { get; set; }

        public Person(string firstName, string lastName, string color)
        {
            FirstName = firstName;
            LastName = lastName;
            Color = color;
        }     
    }   
}
