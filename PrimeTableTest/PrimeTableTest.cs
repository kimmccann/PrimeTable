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

        [TestMethod]
        public void firstThreePrimes()
        {
            List<int> primesList = new List<int>();
            primesList.Add(2);
            primesList.Add(3);
            primesList.Add(5);
            List<int> result = PrimeTable.PrimeTable.getPrimes(3);
            CollectionAssert.AreEqual(primesList, result);
        }

        [TestMethod]
        public void firstTenPrimes()
        {
            List<int> primesList = new List<int>();
            primesList.Add(2);
            primesList.Add(3);
            primesList.Add(5);
            primesList.Add(7);
            primesList.Add(11);
            primesList.Add(13);
            primesList.Add(17);
            primesList.Add(19);
            primesList.Add(23);
            primesList.Add(29);
            List<int> result = PrimeTable.PrimeTable.getPrimes(10);
            CollectionAssert.AreEqual(primesList, result);
        }

    }
}
