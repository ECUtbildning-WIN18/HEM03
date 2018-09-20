namespace HEM03.Domain
{
    class Person 
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FavoritColor { get; }
        public string Rank { get; set; }

        public Person(string firstName, string lastName, string favoritColor)
        {
            FirstName = firstName;
            LastName = lastName;
            FavoritColor = favoritColor;
            Rank = "enlisted";
        }

        public void ChangeFirstName(string firstName)
        {
            FirstName = firstName;
        }

        public void ChangeLastName(string lastName)
        {
            LastName = lastName;
        }
    }
}
