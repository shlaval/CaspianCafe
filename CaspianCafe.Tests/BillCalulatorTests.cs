using CaspianCafe.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
        public void BillCalculator_CalculateServiceCharge_Ok()
        {
            var billCalculator = new BillCalculator();

            // All Drinks, no service charge
            var menuItems1 = new string[] { "Cola", "Coffee", "Cola", "Coffee", "Cola" };
            var charge1 = billCalculator.CalculateServiceCharge(menuItems1, 3.5D);
            Assert.AreEqual(0.0D, charge1);

            // Drinks plus cheese sandwich, 10% service charge
            var menuItems2 = new string[] { "Cola", "Coffee", "Cola", "Coffee", "Cola", "Cheese Sandwich" };
            var charge2 = billCalculator.CalculateServiceCharge(menuItems2, 5.5D);
            Assert.AreEqual(0.55D, charge2);

            // Any steak sandwich, 20% service charge
            var menuItems3 = new string[] { "Cola", "Coffee", "Cola", "Coffee", "Cola", "Steak Sandwich" };
            var charge3 = billCalculator.CalculateServiceCharge(menuItems3, 8.0D);
            Assert.AreEqual(1.6D, charge3);

            // Service charge capped at £20
            var menuItems4 = (new string[] { "Cola", "Coffee", "Cola", "Coffee", "Cola", "Cheese Sandwich" })
                .Union(Enumerable.Repeat("Steak Sandwich", 40))
                .ToArray();
            var charge4 = billCalculator.CalculateServiceCharge(menuItems4, 185.5D);
            Assert.AreEqual(20.0D, charge4);
        }

        [TestMethod]
        public void BillCalculator_CalculateBill_Ok()
        {
            var billCalculator = new BillCalculator();
            var menuItems = new string[] { "Cola", "Coffee", "Cheese Sandwich" };

            var billAmount = billCalculator.CalculateBill(menuItems);

            Assert.AreEqual(3.85D, billAmount);

            menuItems = new string[] { "Cola", "Steak Sandwich" };
            billAmount = billCalculator.CalculateBill(menuItems);

            Assert.AreEqual(6.0D, billAmount);
        }
    }
}
