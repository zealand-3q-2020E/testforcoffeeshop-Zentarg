using System;
using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeeShopConsoleAppUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPriceMethodBlackCoffee()
        {
            Coffee blackCoffee = new BlackCoffee();

            Assert.AreEqual(20, blackCoffee.price());
        }
        [TestMethod]
        public void TestPriceMethodLatte()
        {
            Coffee latte = new Latte();

            Assert.AreEqual(40, latte.price());
        }
        [TestMethod]
        public void TestPriceMethodCortado()
        {
            Coffee cortado = new Cortado();

            Assert.AreEqual(25, cortado.price());
        }
        
        [TestMethod]
        public void TestStrengthMethodBlackCoffee()
        {
            Coffee blackCoffee = new BlackCoffee();

            Assert.AreEqual("Strong", blackCoffee.Strength());
        }
        [TestMethod]
        public void TestStrengthMethodLatte()
        {
            Coffee latte = new Latte();

            Assert.AreEqual("Weak", latte.Strength());
        }
        [TestMethod]
        public void TestStrengthMethodCortado()
        {
            Coffee cortado = new Cortado();

            Assert.AreEqual("Medium", cortado.Strength());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDiscountMethodExceptionBlackCoffee()
        {
            Coffee test = new BlackCoffee(6);
            Assert.Fail();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDiscountMethodExceptionCortado()
        {
            Coffee test = new Cortado(6);
            Assert.Fail();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDiscountMethodExceptionFlatWhite()
        {
            Coffee test = new FlatWhite(6);
            Assert.Fail();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDiscountMethodExceptionLatte()
        {
            Coffee test = new Latte(6);
            Assert.Fail();
        }
    }
}
