using System;
using HEM03.Domain;
namespace HEM03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Crew Member!");
            ShipControlSystem shipControlSystem = new ShipControlSystem();
            CrewMember captain = new CrewMember("Adama", "Captain");
            captain.trivia = "Favorite color is green";
            shipControlSystem.AddCrewMember(captain);
            shipControlSystem.AddCrewMember(new CrewMember("Secincom", "Chief Mate"));
            Vehicle ship = new Ship("Explorada", "Num001", EngineTypes.FTL);
            Vehicle golfCart = new GolfCart("LazyTee", "Car701", EngineTypes.Yamaha_G19);

            foreach(CrewMember crewMember in shipControlSystem.crewMembers)
            {
                ship.AddPermission(crewMember.crewMemberId);
            }
            golfCart.AddPermission(shipControlSystem.crewMembers.Find(CrewMember => CrewMember.name == "Adama").crewMemberId); 

            shipControlSystem.AddVehicle(ship);
            shipControlSystem.AddVehicle(golfCart);
            shipControlSystem.NavigateVehicle(Domain.Action.Gas, captain, ship);
            shipControlSystem.PrintCrewMembersNameAndId();
            shipControlSystem.NavigateVehicle(Domain.Action.Gas,shipControlSystem.GetCrewMember(2), golfCart);
        }
    }
}
