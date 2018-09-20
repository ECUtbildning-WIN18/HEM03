using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Domain
{
    class Vehicle
    {
        private string Owner { get; }
        private string Model { get; }
        private string RegistrationNumber { get; }
        private bool CupHolder { get; }

        public Vehicle(string owner, string model, string registrationNumber, bool cupHolder)
        {
            Owner = owner;
            Model = model;
            RegistrationNumber = registrationNumber;
            CupHolder = cupHolder;
        }
    }
}
