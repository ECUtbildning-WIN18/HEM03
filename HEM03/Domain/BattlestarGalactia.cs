namespace HEM03.Domain
{
    class BattlestarGalactia : SpaceVehicle
    {
        public string FirstNavigationOfficer { get; }

        public BattlestarGalactia (string model, string registrationNumber, 
            string firstNavigationOfficer, Engine engineType, OwnerOfSpaceVehicles owner)
            :base (model, registrationNumber)
         {
            FirstNavigationOfficer = firstNavigationOfficer;

         }
    }
}
