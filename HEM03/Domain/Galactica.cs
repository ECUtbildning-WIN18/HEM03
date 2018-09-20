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
            Engine = new Engine(987654, 905000, "Hypersonic", true);
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
        }

        public void Brake()
        {
            Engine.DecreasePower();
            Speed = Engine.Output / 3;
        }
    }
}
