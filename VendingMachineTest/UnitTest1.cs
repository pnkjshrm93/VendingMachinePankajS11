using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendingMachineApp;

namespace VendingMachineTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_GetCoinValueWithProperValue()
        {
            VendingMachine vending = new VendingMachine();
            int coinValue = vending.GetCoinValue(20, 20);
            Assert.AreEqual(coinValue, 20);
        }

        [TestMethod]
        public void TestMethod_GetCoinValueWithoutProperValue()
        {
            VendingMachine vending = new VendingMachine();
            int coinValue = vending.GetCoinValue(50, 20);
            Assert.ThrowsException<System.ArgumentException>(() => vending.GetCoinValue(50, 20));
            Assert.AreEqual(coinValue, 20);
        }

        [TestMethod]
        public void TestMethod_UpdateTotalAmountWithNickel()
        {
            VendingMachine vending = new VendingMachine();
            int updatedValue = vending.UpdatedTotalAmount(vending.GetCoinValue(20, 20));
            Assert.AreEqual(updatedValue, vending.GetCoinValue(20, 20));
        }

        [TestMethod]
        public void TestMethod_UpdateTotalAmountWithDimes()
        {
            VendingMachine vending = new VendingMachine();
            int updatedValue = vending.UpdatedTotalAmount(vending.GetCoinValue(20, 20));
            Assert.AreEqual(updatedValue, vending.GetCoinValue(20, 20));
        }
    }
}
