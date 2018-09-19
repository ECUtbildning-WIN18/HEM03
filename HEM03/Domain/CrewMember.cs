using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class CrewMember
    {
        private string m_name,m_rank, m_trivia;
        private int m_crewMemberId;
        
        public CrewMember(string name, string rank)
        {
            this.m_name = name;
            this.m_rank = rank;
            this.m_trivia = "No info";
            this.m_crewMemberId = -1;
        }
        public void setTrivia(string trivia)
        {
            this.m_trivia = trivia;
        }
        public string getTrivia()
        {
            return this.m_trivia;
        }
        public void setCrewMemberId(int crewMemberId)
        {
            this.m_crewMemberId = crewMemberId;
        }
        public int GetCrewMemberId()
        {
            return this.m_crewMemberId;
        }
        public void addVehiclePermission(Vehicle vehicle)
        {
            vehicle.addPermission(this.m_crewMemberId);     
        }
        public string GetName()
        {
            return this.m_name;
        }
    }
}
