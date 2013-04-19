using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problem4
{
    public static class IntExtensions
    {
        public static bool IsPalindrome(this int i)
        {
            var s = i.ToString();
            
            if (s.Length%2 != 0)
                return false;

            var halfway = s.Length/2;
            var half = s.Substring(0, halfway);
            var flipped = half.ToCharArray().Aggregate(string.Empty, (current, @char) => @char + current);

            return s.Substring(halfway) == flipped;
        }
    }
}
