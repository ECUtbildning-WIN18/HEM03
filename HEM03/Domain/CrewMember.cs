using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class CrewMember
    {
        public string name { get; private set; }
        public string trivia { get; set; }
        private string rank;
        public int crewMemberId { get; set; }
        
        public CrewMember(string name, string rank)
        {
            this.name = name;
            this.rank = rank;
            trivia = "No info";
            crewMemberId = -1;
        }

        public void AddVehiclePermission(Vehicle vehicle)
        {
            vehicle.AddPermission(crewMemberId);     
        }

    }
}
