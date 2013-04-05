using System;
using System.Collections.Generic;

namespace ProjectEuler.Problem2
{
    public class OddsOnlyPrimeFinder : TrialDivisionPrimeFinder
    {
        public override bool IsPrime(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            var limit = Math.Sqrt(n);

            for (var i = 3; i <= limit; i+= 2)
            {
                var isDivisible = (n % i == 0);
                var isntN = i != n;

                if (isDivisible && isntN)
                    return false;
            }

            return true;
        }

        public override List<long> Find(long start, long end)
        {
            if (start > end)
                throw new ArgumentOutOfRangeException("end", "End Parameter Must Be Greater Than Start");

            var result = new List<long>();
            var limit = Math.Sqrt(end);
            
            for (long i = 3; i <= limit; i+= 2)
            {
                if (end%i == 0)
                {
                    if (IsPrime(i))
                        result.Add(i);
                }
            }

            return result;
        }
    }
}