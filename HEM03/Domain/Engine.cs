using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Engine
    {
        public string EngineType { get; }

        public Engine(string engineType)
        {
            EngineType = engineType;
        }

        public void Gas()
        {
            Console.WriteLine("increasing acceleration");
        }
    }
}
