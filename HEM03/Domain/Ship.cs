using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Ship : Vehicle
    {
        public Person Person { get; }
        public Person Styrman { get; }
        public Engine TheEngine { get; }

        public Ship(string model, string registratioNumber, Person person, Person styrman, Engine engine) :
            base(model, registratioNumber, engine)
        {
            Person = person;
            Styrman = styrman;
        }
    }
}
