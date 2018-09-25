using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    public enum EngineTypes { Yamaha_G19 , FTL};

    class Engine
    {
        public EngineTypes EngineType { get; private set; }
        private float MaxVelocity;
        private float CurrentVelocity;

        public Engine(EngineTypes engineType)
        {
            EngineType = engineType;
            MaxVelocity = (float)engineType * 999 + 1;
            CurrentVelocity = 0;
        }

        public void Gas(float velocityIncrement)
        {
            if (CurrentVelocity != MaxVelocity)
            {
                if (CurrentVelocity + velocityIncrement < MaxVelocity)
                {
                    CurrentVelocity += velocityIncrement;
                }
                else
                {
                    CurrentVelocity = MaxVelocity;
                }
            }
        }

        public void Break(float velocityDecrement)
        {
            if (CurrentVelocity == 0)
            {
                if (CurrentVelocity - velocityDecrement <= 0)
                {
                    CurrentVelocity = 0;
                }
                else
                {
                    CurrentVelocity -= velocityDecrement;
                }
            }
        }
    }
}
