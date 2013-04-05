using System;
using System.Collections.Generic;

namespace ProjectEuler.Problem2
{
    public class TrialDivisionPrimeFinder : IPrimeNumberFinder
    {
        public virtual bool IsPrime(long n)
        {
            if (n < 2)
                return false;

            for (var i = 2; i <= n; i++)
            {
                var isDivisible = (n%i == 0);
                var isntN = i != n;
                
                if (isDivisible && isntN)
                    return false;
            }

            return true;
        }

        public virtual List<long> Find(long start, long end)
        {
            if (start > end)
                throw new ArgumentOutOfRangeException("end", "End Parameter Must Be Greater Than Start");

            var result = new List<long>();

            for (long i = start; i <= end; i++)
            {
                if (IsPrime(i))
                    result.Add(i);
            }

            return result;
        }
    }
}
