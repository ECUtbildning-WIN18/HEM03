using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    public enum EngineTypes { Yamaha_G19 , FTL};

    class Engine
    {
        public EngineTypes engineType { get; private set; }
        private float maxVelocity;
        private float currentVelocity;

        public Engine(EngineTypes engineType)
        {
            this.engineType = engineType;
            maxVelocity = (float)engineType * 999 + 1;
            currentVelocity = 0;
        }

        public void Gas(float velocityIncrement)
        {
            if (currentVelocity != maxVelocity)
            {
                if (currentVelocity + velocityIncrement < maxVelocity)
                {
                    currentVelocity += velocityIncrement;
                }
                else
                {
                    currentVelocity = maxVelocity;
                }
            }
        }

        public void Break(float velocityDecrement)
        {
            if (currentVelocity == 0)
            {
                if (currentVelocity - velocityDecrement <= 0)
                {
                    currentVelocity = 0;
                }
                else
                {
                    currentVelocity -= velocityDecrement;
                }
            }
        }
    }
}
