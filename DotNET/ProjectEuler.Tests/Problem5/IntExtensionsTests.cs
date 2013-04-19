using NUnit.Framework;
using ProjectEuler.Problem5;

namespace ProjectEuler.Tests.Problem5
{
    [TestFixture]
    public class IntExtensionsTests
    {
        [Test]
        public void IsEvenlyDivisible_10by3_ReturnsFalse()
        {
            var result = 10.IsEvenlyDivisible(3);
            Assert.IsFalse(result);
        }
        
        [Test]
        public void IsEvenlyDivisible_10by2_ReturnsTrue()
        {
            var result = 10.IsEvenlyDivisible(2);
            Assert.IsTrue(result);
        }
        
        [Test]
        public void IsEvenlyDivisible_9by3_ReturnsTrue()
        {
            var result = 9.IsEvenlyDivisible(3);
            Assert.IsTrue(result);
        }
        
        [Test]
        public void IsEvenlyDivisible_10by2_5_ReturnsTrue()
        {
            var result = 10.IsEvenlyDivisible(2, 5);
            Assert.IsTrue(result);
        }
        
        [Test]
        public void IsEvenlyDivisible_10by2_3_5_ReturnsFalse()
        {
            var result = 10.IsEvenlyDivisible(2, 3, 5);
            Assert.IsFalse(result);
        }
    }
}
