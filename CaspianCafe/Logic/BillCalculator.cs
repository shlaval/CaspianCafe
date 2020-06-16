using CaspianCafe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("CaspianCafe.Tests")]
namespace CaspianCafe.Logic
{
    public class BillCalculator : IBillCalculator
    {
        private IMenuRepository menuRepository;

        public BillCalculator()
        {
            // In a more realistic application this dependency would be injected into the ctor
            menuRepository = new MenuRepository();
        }

        public double CalculateBill(string[] menuItems)
        {
            var totalBill = 0.0D;
            var allItems = menuRepository.GetMenuItems();

            foreach(var itemName in menuItems)
            {
                var menuItem = allItems.FirstOrDefault(mi => mi.Name == itemName);
                if(menuItem != null)
                {
                    totalBill += menuItem.Price;
                }
            }

            var serviceCharge = CalculateServiceCharge(menuItems);

            return totalBill + serviceCharge;
        }

        internal double CalculateServiceCharge(string[] menuItems)
        {
            return 0.0D;
        }
    }
}
