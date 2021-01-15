using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.utils;
using System.Collections.Generic;

namespace Services.services.Tests
{
    [TestClass()]
    public class DivisorsServicesTests
    {

        private List<int> Expected = new List<int> { 1, 3, 5, 9, 15, 45 };
        private List<int> ExpectedPrime = new List<int> { 1, 3, 5};

        [TestMethod()]
        public void CalcDivisorsTestExpected()
        {
            CollectionAssert.AreEqual(Expected, DivisorsHelper.GetDivisors(45));
        }

        [TestMethod()]
        public void CalcDivisorsTestIsNotNull()
        {
            Assert.IsNotNull(DivisorsHelper.GetDivisors(45));
        }

        [TestMethod()]
        public void CalcPrimeTestIsNotNull()
        {
            Assert.IsNotNull(DivisorsHelper.GetPrimeNumers(DivisorsHelper.GetDivisors(45)));
        }

        [TestMethod()]
        public void CalcPrimeTestExpected()
        {
            CollectionAssert.AreEqual(ExpectedPrime, DivisorsHelper.GetPrimeNumers(DivisorsHelper.GetDivisors(45)));
        }
    }
}