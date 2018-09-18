namespace HEM03.Domain
{
    class GolfCar : SpaceVehicle
    {

        public string GolfCarColor { get; }

        public GolfCar(string model, string registrationNumber,
            string golfCarColor, Engine engineType, OwnerOfSpaceVehicles owner)
            : base(model, registrationNumber)
        {
            GolfCarColor = golfCarColor;


        }
        //public void GetInfoAboutGolfCar()
        //{
        //    Console.WriteLine("This is info about the GolfCar: ");
        //    Console.WriteLine("Owner: " + Owner.Owner);
        //    Console.WriteLine("Colour: " + AdamsGolfCar.GolfCarColor);
        //    Console.WriteLine("Registration number: " + AdamsGolfCar.RegistrationNumber);
        //    Console.WriteLine("Model: " + AdamsGolfCar.Model);
        //    Console.WriteLine("Engine type: " + GolfCarEngine.EngineType);

        

    }
}
