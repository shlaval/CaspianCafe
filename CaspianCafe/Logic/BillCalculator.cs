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

            var serviceCharge = CalculateServiceCharge(menuItems, totalBill);

            return totalBill + serviceCharge;
        }

        internal double CalculateServiceCharge(string[] menuItems, double total)
        {
            var serviceCharge = 0.0D;

            var allItems = menuRepository.GetMenuItems();

            var anyFood = menuItems.Any(mi => !allItems.Single(i => i.Name == mi).IsDrink);
            var anyHotFood = menuItems.Any(mi => !allItems.Single(i => i.Name == mi).IsDrink &&
                                                 !allItems.Single(i => i.Name == mi).IsCold);

            if(anyHotFood)
            {
                serviceCharge = total * 0.2D;
            }
            else if(anyFood)
            {
                serviceCharge = total * 0.1D;
            }

            return serviceCharge < 20.0D ? Math.Round(serviceCharge, 2) : 20.0D;
        }
    }
}
