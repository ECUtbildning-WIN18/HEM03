using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Vehicle
    {
        private string m_model, m_registrationNumber;
        private Engine m_engine;
        private List<int> m_permisions;
        public Vehicle(string model,string registrationNumber,EngineTypes engineType)
        {
            this.m_engine = new Engine(engineType);
            this.m_model = model;
            this.m_registrationNumber = registrationNumber;
            this.m_permisions = new List<int>();
        }
        public void addPermission(int crewMemberId)
        {
            this.m_permisions.Add(crewMemberId);
        }

        public void Navigate(Action action, CrewMember crewMember)
        {
            if(checkPermission(crewMember.GetCrewMemberId()))
            {
                if(action == Action.Gas)
                {
                    this.m_engine.Gas((int)this.m_engine.GetEngineType()*9+1);
                }
                if(action == Action.Break)
                {
                    this.m_engine.Break((int)this.m_engine.GetEngineType() * 4 + 1);
                }
            }
            else
            {
                Console.WriteLine("Current crew member does not have permission to navigate this vehicle!");
            }
        }
        
        private bool checkPermission(int crewMemberId)
        {
            if(this.m_permisions.Contains(crewMemberId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetRegistrationNumber()
        {
            return this.m_registrationNumber;
        }
        public virtual string GetVehicleType()
        {
            return "default vehicle type";
        }
    }
}
