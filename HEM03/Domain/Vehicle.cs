using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Vehicle
    {
        public string Model { get; set; }
        public int RegistrationNumber { get; set; }        


        public Vehicle(string model, int registrationNumber)
        {
            Model = model;
            RegistrationNumber = registrationNumber;
            
        }

    }
}
