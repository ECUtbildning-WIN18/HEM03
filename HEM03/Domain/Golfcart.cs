using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Golfcart : Vehicle
    {        
        public Person Person { get; }  
        public Engine TheEngine { get; }

        public Golfcart(string model, string registratioNumber, Person person, Engine engine) :
            base(model, registratioNumber, engine)
        {
            Person = person;
            TheEngine = engine;
        }        
    }
}