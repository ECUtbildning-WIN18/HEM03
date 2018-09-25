using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain2
{
    class Person
    {
        public string Title { get; }
        public string Name { get; }
        public Person(string title, string name)
        {
            Title = title;
            Name = name;
        }
    }
}