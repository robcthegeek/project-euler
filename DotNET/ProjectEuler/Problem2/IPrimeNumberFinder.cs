using System.Collections.Generic;

namespace ProjectEuler.Problem2
{
    public interface IPrimeNumberFinder
    {
        List<long> Find(long start, long end);
        bool IsPrime(long n);
    }
}