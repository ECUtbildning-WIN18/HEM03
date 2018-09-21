using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class SpaceShip : Vehicle
    {
        
        public Person FirstMate { get; }
         

        public SpaceShip(Person firstMate, string regNumber, Person owner) : base(regNumber,"Galactica",owner, new Engine(100, "FTL"))
        {
            FirstMate = firstMate;
        }

        public void Lightspeed()
        {
            int Output = 1000;
        }
    }
}
