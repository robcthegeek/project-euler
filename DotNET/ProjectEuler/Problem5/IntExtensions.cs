using System.Linq;

namespace ProjectEuler.Problem5
{
    public static class IntExtensions
    {
        public static bool IsEvenlyDivisible(this int value, params int[] by)
        {
            return by.All(x => value%x == 0);
        }
    }
}
