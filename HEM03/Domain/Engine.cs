using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    public enum EngineTypes { Yamaha_G19 , FTL};
    class Engine
    {
        private EngineTypes m_engineType;
        private float m_maxVelocity, m_currentVelocity;
        public Engine(EngineTypes type)
        {
            this.m_engineType = type;
            this.m_maxVelocity = (float)type*999 + 1;
            this.m_currentVelocity = 0;
        }
        public void Gas(float velocityIncrement)
        {
            if (this.m_maxVelocity != this.m_currentVelocity)
            {
                if (this.m_currentVelocity + velocityIncrement < this.m_maxVelocity)
                {
                    this.m_currentVelocity += velocityIncrement;
                }
                else
                {
                    this.m_currentVelocity = this.m_maxVelocity;
                }
            }
        }
        public void Break(float velocityDecrement)
        {
            if (this.m_currentVelocity == 0)
            {
                if (this.m_currentVelocity - velocityDecrement <= 0)
                {
                    this.m_currentVelocity = 0;
                }
                else
                {
                    this.m_currentVelocity -= velocityDecrement;
                }
            }

        }
        public EngineTypes GetEngineType()
        {
            return this.m_engineType;
        }
    }
}
