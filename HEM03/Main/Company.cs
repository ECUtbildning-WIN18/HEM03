using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Main
{
    class Company
    {
        public string Name { get; set; }

        public string Owner { get; set; }

        public string FavoritColor { get; set; }

        public string Employee { get; set; }

        public Company(string name, string owner, string favoritColor, string employee)

        {
            Name = name;
            Owner = owner;
            FavoritColor = favoritColor;
            Employee = employee;


        }


        
    }
}