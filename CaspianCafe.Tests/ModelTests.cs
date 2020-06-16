using CaspianCafe.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaspianCafe.Tests
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void MenuItem_ctor_Ok()
        {
            var name = "Cola";
            var isCold = true;
            var price = 0.5D;

            var menuItem = new MenuItem(name, isCold, price);

            Assert.AreEqual(name, menuItem.Name);
            Assert.AreEqual(isCold, menuItem.IsCold);
            Assert.AreEqual(price, menuItem.Price);
        }
    }
}
