using CaspianCafe.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaspianCafe.Tests
{
    [TestClass]
    public class BillCalulatorTests
    {
        [TestMethod]
        public void BillCalculator_ctor_Ok()
        {
            var billCalculator = new BillCalculator();

            Assert.IsNotNull(billCalculator);
        }

        [TestMethod]
        public void BillCalculator_CalculateBill_Ok()
        {
            var billCalculator = new BillCalculator();
            var menuItems = new string[] { "Cola", "Coffee", "Cheese Sandwich" };

            var billAmount = billCalculator.CalculateBill(menuItems);

            Assert.AreEqual(3.5D, billAmount);
        }
    }
}
