using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class SpaceShip : Vehicle
    {
        
        public Person FirstMate { get; }
        public FTL Ftl { get; }
        
         
        // Den tar in "FTL" som Engine tack vare att FTL ärver av Engine.
        public SpaceShip(Person firstMate, string regNumber, Person owner, FTL ftl) : base(regNumber,"Galactica",owner, ftl)
        {
            FirstMate = firstMate;
            Ftl = ftl;
        }

    }
}
