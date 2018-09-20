using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Persons
    {
        public string Commander { get; }
        public string FirstMate { get; }

        public Persons(string commander, string firstMate)
        {
            Commander = commander;
            FirstMate = firstMate;
        }

    }
}
