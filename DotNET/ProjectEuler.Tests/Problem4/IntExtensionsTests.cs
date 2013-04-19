using NUnit.Framework;
using ProjectEuler.Problem4;

namespace ProjectEuler.Tests.Problem4
{
    [TestFixture]
    public class IntExtensionsTests
    {
        [Test]
        public void IsPalindrome_Zero_ReturnsFalse()
        {
            var result = 0.IsPalindrome();
            Assert.IsFalse(result);
        }
        
        [Test]
        public void IsPalindrome_1337_ReturnsFalse()
        {
            var result = 1337.IsPalindrome();
            Assert.IsFalse(result);
        }
        
        [Test]
        public void IsPalindrome_337_ReturnsFalse()
        {
            var result = 337.IsPalindrome();
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPalindrome_9009_ReturnsTrue()
        {
            var result = 9009.IsPalindrome();
            Assert.IsTrue(result);
        }
        
        [Test]
        public void IsPalindrome_90099009_ReturnsTrue()
        {
            var result = 90099009.IsPalindrome();
            Assert.IsTrue(result);
        }
    }
}
