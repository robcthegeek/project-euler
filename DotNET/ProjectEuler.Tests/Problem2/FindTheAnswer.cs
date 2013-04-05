using System;
using NUnit.Framework;
using ProjectEuler.Problem2;

namespace ProjectEuler.Tests.Problem2
{
    [TestFixture]
    public class FindTheAnswer
    {
        [Test]
        public void FindLargest_600851475143_ReturnsTHEANSWER()
        {
            var primes = new OddsOnlyPrimeFinder();
            var factors = new PrimeFactorFinder(primes);
            var result = factors.FindLargest(600851475143);
            Console.Write(result);
        }
    }
}
