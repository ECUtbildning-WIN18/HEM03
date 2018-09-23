using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class CrewMember
    {
        public string Name { get; private set; }
        public string Trivia { get; set; }
        private readonly string rank;
        public int CrewMemberId { get; set; }
        
        public CrewMember(string name, string rank)
        {
            Name = name;
            this.rank = rank;
            Trivia = "No info";
            CrewMemberId = -1;
        }

        public void AddVehiclePermission(Vehicle vehicle)
        {
            vehicle.AddPermission(CrewMemberId);     
        }

    }
}
