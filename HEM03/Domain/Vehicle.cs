using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Vehicle
    {
        public string RegistrationNumber { get; private set; }
        private string model;
        private Engine engine;
        private HashSet<int> permisions = new HashSet<int>();

        public Vehicle(string model,string registrationNumber,EngineTypes engineType)
        {
            engine = new Engine(engineType);
            this.model = model;
            RegistrationNumber = registrationNumber;
        }

        public void AddPermission(int crewMemberId)
        {
            permisions.Add(crewMemberId);
        }

        public void Navigate(Action action, CrewMember crewMember)
        {
            if(CheckPermission(crewMember.CrewMemberId))
            {
                if(action == Action.Gas)
                {
                    engine.Gas((int)engine.engineType * 9 + 1);
                }
                if(action == Action.Break)
                {
                    engine.Break((int)engine.engineType * 4 + 1);
                }
            }
            else
            {
                Console.WriteLine("Current crew member does not have permission to navigate this vehicle!");
            }
        }
        
        private bool CheckPermission(int crewMemberId)
        {
            return permisions.Contains(crewMemberId);
        }

        public virtual string GetVehicleType()
        {
            return "default vehicle type";
        }
    }
}
