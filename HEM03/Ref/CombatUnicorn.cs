using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Domain
{
    class CombatUnicorn : Unit
    {
        public string RegistrationNumber { get; }

        public CombatUnicorn(string registrationNumber):base(200, 50)
        {
            RegistrationNumber = registrationNumber;
        }
        public override void WarScream()
        {
            Console.WriteLine("GNNNNNNRDÖLA!!");
        }
        public override void PrintStatus()
        {
            Console.WriteLine("HUBUBUBBBB!!!");
        }
    }
}
