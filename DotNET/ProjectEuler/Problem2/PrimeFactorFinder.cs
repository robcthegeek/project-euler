using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problem2
{
    public class PrimeFactorFinder
    {
        private readonly IPrimeNumberFinder _primeFinder;

        public PrimeFactorFinder(IPrimeNumberFinder primeFinder)
        {
            _primeFinder = primeFinder;
        }

        public List<long> FindAll(long n)
        {
            var primes = _primeFinder.Find(0, n) ?? new List<long>();
            return primes.Where(prime => n%prime == 0).ToList();
        }

        public long FindLargest(long n)
        {
            var factors = FindAll(n);
            return factors.Last();
        }
    }
}
