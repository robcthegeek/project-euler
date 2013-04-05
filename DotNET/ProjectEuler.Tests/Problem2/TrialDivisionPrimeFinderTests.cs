using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler.Problem2;

namespace ProjectEuler.Tests.Problem2
{
    [TestFixture]
    public class TrialDivisionPrimeFinderTests
    {
        private IPrimeNumberFinder _finder;

        [SetUp]
        public void Setup()
        {
            _finder = new TrialDivisionPrimeFinder();
        }

        [Test]
        public void IsPrime_Zero_ReturnsFalse()
        {
            var result = _finder.IsPrime(0);
            Assert.IsFalse(result);
        }
        
        [Test]
        public void IsPrime_One_ReturnsFalse()
        {
            var result = _finder.IsPrime(1);
            Assert.IsFalse(result);
        }
        
        [Test]
        public void IsPrime_Two_ReturnsTrue()
        {
            var result = _finder.IsPrime(2);
            Assert.IsTrue(result);
        }
        
        [Test]
        public void IsPrime_Three_ReturnsTrue()
        {
            var result = _finder.IsPrime(3);
            Assert.IsTrue(result);
        }
        
        [Test]
        public void IsPrime_242_ReturnsTrue()
        {
            var result = _finder.IsPrime(242);
            Assert.IsFalse(result);
        }
        
        [Test]
        public void IsPrime_401_ReturnsTrue()
        {
            var result = _finder.IsPrime(401);
            Assert.IsTrue(result);
        }
        
        [Test]
        public void IsPrime_997_ReturnsTrue()
        {
            var result = _finder.IsPrime(997);
            Assert.IsTrue(result);
        }
        
        [Test]
        public void Find_EndLessThanStart_ArgumentOutOfRangeException()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(
                () => _finder.Find(10, 5));
            Assert.AreEqual("end", ex.ParamName);
        }

        [Test]
        public void Find_1to6_Returns2_3_5()
        {
            var result = _finder.Find(1, 6);
            Assert.AreEqual(3, result.Count());
            Assert.Contains(2, result);
            Assert.Contains(3, result);
            Assert.Contains(5, result);
        }
        
        [Test]
        public void Find_200to230_Returns211_223_227_229()
        {
            var result = _finder.Find(200, 230);
            Assert.AreEqual(4, result.Count());
            Assert.Contains(211, result);
            Assert.Contains(223, result);
            Assert.Contains(227, result);
            Assert.Contains(229, result);
        }
    }
}
