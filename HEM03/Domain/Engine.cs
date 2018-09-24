using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Engine
    {
        public uint Output { get; private set; }
        public string Model { get; }
        public uint MaxOutput { get; private set; }
        
        public Engine(uint maxOutput, string model)
        {
            MaxOutput = maxOutput;
            Model = model;
        }

        public void IncreaseOutput()
        {
            Output += 100;

            if (Output >= MaxOutput)
            {
                Output = MaxOutput;
            }
        }
    }
}
