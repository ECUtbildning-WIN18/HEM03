using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Vehicle
    {
        public string RegistrationNumber { get; private set; }
        private string Model;
        private Engine Engine;
        private HashSet<int> Permisions = new HashSet<int>();

        public Vehicle(string model,string registrationNumber,EngineTypes engineType)
        {
            Engine = new Engine(engineType);
            Model = model;
            RegistrationNumber = registrationNumber;
        }

        public void AddPermission(int crewMemberId)
        {
            Permisions.Add(crewMemberId);
        }

        public void Navigate(Action action, CrewMember crewMember)
        {
            if(CheckPermission(crewMember.CrewMemberId))
            {
                if(action == Action.Gas)
                {
                    Engine.Gas((int)Engine.EngineType * 9 + 1);
                }
                if(action == Action.Break)
                {
                    Engine.Break((int)Engine.EngineType * 4 + 1);
                }
            }
            else
            {
                Console.WriteLine("Current crew member does not have permission to navigate this vehicle!");
            }
        }
        
        private bool CheckPermission(int crewMemberId)
        {
            return Permisions.Contains(crewMemberId);
        }

        public virtual string GetVehicleType()
        {
            return "default vehicle type";
        }
    }
}
