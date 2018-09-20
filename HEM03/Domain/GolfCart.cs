using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class GolfCart : Vehicle
    {
        public string SpaceGpsModel { get; set; }
        public Engine Engine { get; }

        public GolfCart(string model, 
            string registrationNumber,
            string color, 
            Person owner,
            string spaceGpsModel) 
            : base(model, 
                  registrationNumber, 
                  color, 
                  owner)
        {
            SpaceGpsModel = spaceGpsModel;
            Engine = new Engine(123456, 36, "Electric", false);
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
