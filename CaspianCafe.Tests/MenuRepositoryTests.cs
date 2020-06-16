using CaspianCafe.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaspianCafe.Tests
{
    [TestClass]
    public class MenuRepositoryTests
    {
        [TestMethod]
        public void MenuRepository_ctor_Ok()
        {
            var menuRepository = new MenuRepository();

            Assert.IsNotNull(menuRepository);
        }

        [TestMethod]
        public void MenuRepository_GetMenuItems_Ok()
        {
            var menuRepository = new MenuRepository();
            var menuItems = menuRepository.GetMenuItems();

            Assert.AreEqual(4, menuItems.Count);

            Assert.IsTrue(menuItems.Any(mi => mi.Name == "Cola" && mi.IsCold == true && mi.Price == 0.5D));
            Assert.IsTrue(menuItems.Any(mi => mi.Name == "Coffee" && mi.IsCold == false && mi.Price == 1.0D));
            Assert.IsTrue(menuItems.Any(mi => mi.Name == "Cheese Sandwich" && mi.IsCold == true && mi.Price == 2.0D));
            Assert.IsTrue(menuItems.Any(mi => mi.Name == "Steak Sandwich" && mi.IsCold == false && mi.Price == 4.5D));
        }
    }
}
