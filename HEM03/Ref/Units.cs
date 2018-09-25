using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Domain
{
    abstract class Unit
    {
        internal int Health { get; set; }
        public int DamageGiven { get; set; }

        public Unit(int health, int damageGiven)
        {
            Health = health;
            DamageGiven = damageGiven;
        }
        public void Attack(Unit unit)
        {
            unit.Defend(DamageGiven);
        }
        public void Defend(int damageGiven)
        {
            Health -= damageGiven;
        }
        public bool IsAlive
        {
            get { return Health > 0; }
        }
        public abstract void WarScream();

        public abstract void PrintStatus();
    }
}
