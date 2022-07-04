using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Edabit.Test
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void CupSwagginControlTest()
        {
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { "AB", "CA" }), "C");
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { "AB", "CA", "AB" }), "C");
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { "AC", "CA", "CA", "AC" }), "B");
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { "BA", "AC", "CA", "BC" }), "A");
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { "BC", "CB", "CA", "BA" }), "A");
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { "BC" }), "C");
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { "BA", "CA", "CB", "CA" }), "B");
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { }), "B");

        }

        [TestMethod]
        public void NextPrimeControlTest()
        {
            Assert.AreEqual(NextPrimeControl.NextPrime(12),13);
            Assert.AreEqual(NextPrimeControl.NextPrime(24),29);
            Assert.AreEqual(NextPrimeControl.NextPrime(11),11);
            Assert.AreEqual(NextPrimeControl.NextPrime(13),13);
            Assert.AreEqual(NextPrimeControl.NextPrime(14),17);
            Assert.AreEqual(NextPrimeControl.NextPrime(33),37);
        }
    }
}