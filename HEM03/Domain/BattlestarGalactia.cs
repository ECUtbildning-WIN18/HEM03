using System;
namespace HEM03.Domain
{
    class BattlestarGalactia : Vehicle
    {
       public string FirstNavigationOfficer { get; }

        public BattlestarGalactia (string model, string registrationNumber, 
            string firstNavigationOfficer, string engineType, string owner)
            :base (model, registrationNumber, engineType, owner)
        {
            FirstNavigationOfficer = firstNavigationOfficer;
        }

        public void PrintInfoAboutBattlestarGalactia()
        {
            Console.WriteLine("This is info about the Battlestar Galactica: ");
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine($"Registration number: {RegistrationNumber}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Engine type: {EngineType}");
            Console.WriteLine(" ");
        }

        public override void Accelerate() 
        {
            Console.WriteLine("Battlestar Galactica accelerate and you will now raise your speed. " +
                "Call your mum and tell her that you love her." +
                " This speed is very fast and you may die...");
        }

    }
}
