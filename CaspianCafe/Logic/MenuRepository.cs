using CaspianCafe.Interfaces;
using CaspianCafe.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaspianCafe.Logic
{
    public class MenuRepository : IMenuRepository
    {
        public IList<MenuItem> GetMenuItems()
        {
            return new List<MenuItem>()
            {
                new MenuItem("Cola", true, 0.5D),
                new MenuItem("Coffee", false, 1.0D),
                new MenuItem("Cheese Sandwich", true, 2.0D),
                new MenuItem("Steak Sandwich", false, 4.5D)
            };
        }
    }
}
