using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    public enum Action { Gas, Break};

    class ShipControlSystem
    {
        public Dictionary<int,CrewMember> CrewMembers { get; private set; }
        public Dictionary<string, Vehicle> Vehicles { get; private set; }

        public ShipControlSystem()
        {
            Vehicles = new Dictionary<string, Vehicle>();
            CrewMembers = new Dictionary<int, CrewMember>();
        }

        public void NavigateVehicle(Action action, CrewMember crewMember, Vehicle vehicle)
        {
            vehicle.Navigate(action, crewMember);
        }

        public void AddCrewMember(CrewMember  crewMember)
        {
            crewMember.CrewMemberId = CrewMembers.Count;
            CrewMembers.Add(crewMember.CrewMemberId, crewMember);
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle.RegistrationNumber, vehicle);
        }

        public CrewMember GetCrewMember(int crewMemberId)
        {
            return CrewMembers[crewMemberId];
        }

        public int GetCrewMemberId(string name)
        {
            foreach(KeyValuePair<int, CrewMember> crewMember in CrewMembers)
            {
                if(crewMember.Value.Name==name)
                {
                    return crewMember.Key;
                }
            }
            return -1;
        }

        public Vehicle GetVehicle(string registrationNumber)
        {
            return Vehicles[registrationNumber];
        }

        public void PrintCrewMembersNameAndId()
        {
            foreach(KeyValuePair<int,CrewMember> crewMember in CrewMembers)
            {
                Console.WriteLine($"Id: { crewMember.Key } \tName: {crewMember.Value.Name}");
            }
        }
    }
}
