using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Galactica : Vehicle
    {
        public bool SeatBelt { get; }
        public new Engine Engine { get; }

        public Galactica(string model,
            string registrationNumber,
            string color,
            Person owner,
            bool seatBelt)
            : base(model,
                  registrationNumber,
                  color,
                  owner)
        {
            Random rnd = new Random();
            int currentMotorMood = rnd.Next(500000, 1000000);
            Engine = new Engine(987654, currentMotorMood, "Hypersonic", true);
            SeatBelt = true;
        }

        public void Loop()
        {
            Console.WriteLine("Wooooaaaaaahoooo...!");
        }

        public void Accelerate()
        {
            Engine.IncreasePower();
            Speed = Engine.Output * 3;
            Console.Write("Accelerating, ");
        }

        public void Brake()
        {
            Engine.DecreasePower();
            Speed = Engine.Output / 3;
            Console.Write("Braking, ");
        }
    }
}
