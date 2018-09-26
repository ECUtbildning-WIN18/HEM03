namespace HEM03.Main
{
    class Golfcar : Vehicle
    {
        public int Doors { get; set; }

        public Golfcar(string model, string registrationNumber, string motor, int doors)
            : base(model, registrationNumber, motor)

        {
            Doors = doors;
        }
                         
    }
}
