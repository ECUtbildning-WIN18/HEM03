using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    
    public enum Action { Gas, Break};
    class ShipControlSystem
    {
        private List<CrewMember> m_crewMembers;
        private List<Vehicle> m_vehicles;
        private int m_nrOfCrewMembers;

        public ShipControlSystem()
        {
            this.m_vehicles = new List<Vehicle>();
            this.m_crewMembers = new List<CrewMember>();
            this.m_nrOfCrewMembers = 0;
        }
        public void NavigateVehicle(Action action, CrewMember crewMember, Vehicle vehicle)
        {
            foreach (Vehicle currVehicle in this.m_vehicles)
            {
                if (currVehicle.Equals(vehicle))
                {
                    currVehicle.Navigate(action, crewMember);
                    return;
                }
            }
        }

        public void addCrewMember(CrewMember  crewMember)
        {
            this.m_nrOfCrewMembers++;
            crewMember.setCrewMemberId(this.m_nrOfCrewMembers);
            this.m_crewMembers.Add(crewMember);
        }
        public void addVehicle(Vehicle vehicle)
        {
            this.m_vehicles.Add(vehicle);
        }
        public CrewMember GetCrewMember(int crewMemberId)
        {
            return this.m_crewMembers.Find(CrewMember => CrewMember.GetCrewMemberId()==crewMemberId);
        }
        public Vehicle GetVehicle(string registrationNumber)
        {
            return this.m_vehicles.Find(Vehicle => Vehicle.GetRegistrationNumber() == registrationNumber);
        }
        public List <Vehicle> GetVehicles()
        {
            return this.m_vehicles;
        }
        public List<CrewMember> GetCrewMembers()
        {
            return this.m_crewMembers;
        }
        public void PrintCrewMembersNameAndId()
        {
            foreach(CrewMember crewMember in this.m_crewMembers)
            {
                Console.WriteLine("Id: " + crewMember.GetCrewMemberId() +
                    "\tName: " + crewMember.GetName());
            }
        }
    }
}
