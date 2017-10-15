using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace StringCalculatorTest
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void CheckReturnValueOne()
        {
            Shared shared = new Shared();
            int returnValue = shared.Add("1");
            Assert.AreEqual(returnValue, 1);
        }

        [TestMethod]
        public void CheckReturnValueForTwoValueAndComa()
        {
            Shared shared = new Shared();
            int returnValue = shared.Add("1,2");
            Assert.AreEqual(returnValue, 3);
        }

        [TestMethod]
        public void CheckReturnValueForNullString()
        {
            Shared shared = new Shared();
            int returnValue = shared.Add(null);
            Assert.AreEqual(returnValue, 0);
        }

        [TestMethod]
        public void CheckReturnValueForEmptyString()
        {
            Shared shared = new Shared();
            int returnValue = shared.Add(string.Empty);
            Assert.AreEqual(returnValue, 0);
        }

        [TestMethod]
        public void CheckReturnValueForSpacebare()
        {
            Shared shared = new Shared();
            int returnValue = shared.Add("  ");
            Assert.AreEqual(returnValue, 0);
        }

        [TestMethod]
        public void CheckReturnValueForHole()
        {
            Shared shared = new Shared();
            int returnValue = shared.Add(",1,2,3,,4,,5,5");
            Assert.AreEqual(returnValue, 20);
        }

        [TestMethod]
        public void CheckReturnValueForN()
        {
            Shared shared = new Shared();
            int returnValue = shared.Add(",1\n2,3\n,,4,,5\n,5");
            Assert.AreEqual(returnValue, 20);
        }


    }
}
