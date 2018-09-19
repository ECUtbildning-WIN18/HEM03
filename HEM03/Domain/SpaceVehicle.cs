using System;
namespace HEM03.Domain
{
    class SpaceVehicle
    {
        public string Model { get; }
        
        public string RegistrationNumber { get; }

        public SpaceVehicle(string model, string registrationNumber)
        {
            Model = model;
            RegistrationNumber = registrationNumber;
        }
        
    }
}
