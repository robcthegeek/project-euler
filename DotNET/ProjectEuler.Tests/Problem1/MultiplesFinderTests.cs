using System;
using System.Linq;
using NUnit.Framework;
using ProjectEuler.Problem1;

namespace ProjectEuler.Tests.Problem1
{
    public class MultiplesFinderTests
    {
        [Test]
        public void MultiplesOf_5LessThan10_Returns5()
        {
            var finder = new MultiplesFinder(5);
            var results = finder.FindForLessThan(10);
            Assert.AreEqual(1, results.Count);
            Assert.Contains(5, results);
        }
        
        [Test]
        public void MultiplesOf_2or5LessThan6_Returns_2_4_5()
        {
            var finder = new MultiplesFinder(2, 5);
            var results = finder.FindForLessThan(6);
            Assert.AreEqual(3, results.Count);
            Assert.Contains(2, results);
            Assert.Contains(4, results);
            Assert.Contains(5, results);
        }

        [Test]
        public void MultiplesOf_3or5LessThan10_Returns_3_5_6_9()
        {
            var finder = new MultiplesFinder(3, 5);
            var results = finder.FindForLessThan(10);
            Assert.AreEqual(4, results.Count);
            Assert.Contains(3, results);
            Assert.Contains(5, results);
            Assert.Contains(6, results);
            Assert.Contains(9, results);
        }
        
        [Test]
        public void MultiplesOf_3or5LessThan10_Returns_Sum23()
        {
            var finder = new MultiplesFinder(3, 5);
            var results = finder.FindForLessThan(10);
            Assert.AreEqual(23, results.Sum());
        }
        
        [Test]
        public void MultiplesOf_3or5LessThan1000_Returns_THE_ANSWER()
        {
            var finder = new MultiplesFinder(3, 5);
            var results = finder.FindForLessThan(1000);

            Console.Write(results.Sum());
            // Returns: 233168
        }
    }
}
