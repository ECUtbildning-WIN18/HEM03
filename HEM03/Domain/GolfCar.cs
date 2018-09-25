using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class GolfCar : Vehicle
    {
        
        public GolfCar(string regNumber, string brand,string color,
            Owner owner, Engine engine)
            : base(regNumber, brand, color,owner, engine)
        {

        }
        public void Acceleration()
        {
            Console.WriteLine("Brrrr ! ");
        }



        public override void Test()
        {
            Console.WriteLine("GolfCar sound ");
        }

    }
}
