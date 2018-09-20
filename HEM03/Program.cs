using HEM03.Domain;
using System;

namespace HEM03
{
    class Program
    {
        static void Main(string[] args)
        {
            GolfCar golfCar = new GolfCar( "GolfCar",12345, "Adama", "Yamaha G19" );
            BattelStar battelStar = new BattelStar( "Galactia", 12346, "Adama" , "FTL" );

            Console.WriteLine(golfCar.Model+ " "+ golfCar.RegistrationNumber +" "+ golfCar.Enginetype );
            Console.WriteLine(battelStar.Model+" "+battelStar.RegistrationNumber+" " +battelStar.Enginetype);

            golfCar.Accelerate();
            battelStar.Accelerate();       

        }
    }
}
