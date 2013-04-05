using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;
using ProjectEuler.Problem2;

namespace ProjectEuler.Tests.Problem2
{
    [TestFixture]
    public class PrimeFactorFinderFactorTests
    {
        private PrimeFactorFinder _factors;
        private Mock<IPrimeNumberFinder> _primes;

        [SetUp]
        public void Setup()
        {
            _primes = new Mock<IPrimeNumberFinder>();
            _factors = new PrimeFactorFinder(_primes.Object);
        }

        [Test]
        public void FindAll_1WithNoPrimes_ReturnsNone()
        {
            _primes.Setup(x => x.Find(It.IsAny<long>(), It.IsAny<long>())).Returns((List<long>)null);
            var result = _factors.FindAll(1);
            Assert.AreEqual(0, result.Count());
        }
        
        [Test]
        public void FindAll_3WithPrimes2_3_Returns3()
        {
            _primes.Setup(x => x.Find(It.IsAny<long>(), It.IsAny<long>())).Returns(new List<long> { 2, 3 });
            var result = _factors.FindAll(3);
            Assert.AreEqual(1, result.Count());
            Assert.Contains(3, result);
        }
    }
}
