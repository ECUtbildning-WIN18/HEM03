using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Engine
    {
        public int Output { get; set; }
        public string Model { get; }
        

        public Engine(int output, string model)
        {
            Output = output;
            Model = model;
        }


    }
}
