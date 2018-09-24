using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Owner
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public Owner(string firstName, string lastName, string title)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
        }
    }
}
