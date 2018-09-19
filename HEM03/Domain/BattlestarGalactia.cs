using System;
namespace HEM03.Domain
{
    class BattlestarGalactia : SpaceVehicle
    {
        public string FirstNavigationOfficer { get; }
        private OwnerOfSpaceVehicles Owner;
        private Engine Engine;


        public BattlestarGalactia (string model, string registrationNumber, 
            string firstNavigationOfficer, Engine engineType, OwnerOfSpaceVehicles owner)
            :base (model, registrationNumber)
         {
            FirstNavigationOfficer = firstNavigationOfficer;
            this.Owner = owner;
            this.Engine = engineType;

        }
        public void GetInfoAboutBattlestarGalactica()
        {
            Console.WriteLine("This is info about the Battlestar Galactica: ");
            Console.WriteLine("Owner: " + Owner.Owner);
            Console.WriteLine("Registration number: " + RegistrationNumber);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Engine type: " + Engine.EngineType);
            Console.WriteLine("");
        }
    }
}
