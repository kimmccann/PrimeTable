using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PrimeTable;

namespace PrimeTableTest
{
    [TestClass]
    public class PrimeTableTest
    {
        [TestMethod]
        public void firstPrime()
        {
            int prime1 = 2;
            List<int> result = PrimeTable.PrimeTable.getPrimes(1);
            Assert.IsTrue(result.Contains(prime1));
        }

    }
}
