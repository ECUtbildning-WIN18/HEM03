using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    
    public enum Action { Gas, Break};
    class ShipControlSystem
    {
        public List<CrewMember> crewMembers { get; private set; }
        public List<Vehicle> vehicles { get; private set; }
        private int nrOfCrewMembers;

        public ShipControlSystem()
        {
            vehicles = new List<Vehicle>();
            crewMembers = new List<CrewMember>();
            nrOfCrewMembers = 0;
        }

        public void NavigateVehicle(Action action, CrewMember crewMember, Vehicle vehicle)
        {
            foreach (Vehicle currVehicle in vehicles)
            {
                if (currVehicle.Equals(vehicle))
                {
                    currVehicle.Navigate(action, crewMember);
                    return;
                }
            }
        }

        public void AddCrewMember(CrewMember  crewMember)
        {
            nrOfCrewMembers++;
            crewMember.crewMemberId = nrOfCrewMembers;
            crewMembers.Add(crewMember);
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public CrewMember GetCrewMember(int crewMemberId)
        {
            return crewMembers.Find(CrewMember => CrewMember.crewMemberId==crewMemberId);
        }

        public Vehicle GetVehicle(string registrationNumber)
        {
            return vehicles.Find(Vehicle => Vehicle.registrationNumber == registrationNumber);
        }

        public void PrintCrewMembersNameAndId()
        {
            foreach(CrewMember crewMember in crewMembers)
            {
                Console.WriteLine("Id: " + crewMember.crewMemberId +
                    "\tName: " + crewMember.name);
            }
        }
    }
}
