using CaspianCafe.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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

            Assert.AreEqual(3, menuItems.Count);
        }
    }
}
