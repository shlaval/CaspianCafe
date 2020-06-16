using System;
using System.Collections.Generic;
using System.Text;

namespace CaspianCafe.Model
{
    public class MenuItem
    {
        public string Name { get; private set; }
        public bool IsCold { get; private set; }
        public bool IsDrink { get; private set; }
        public double Price { get; private set; }

        public MenuItem(string name, bool isCold, bool isDrink, double price)
        {
            Name = name;
            IsCold = isCold;
            IsDrink = isDrink;
            Price = price;
        }
    }
}
