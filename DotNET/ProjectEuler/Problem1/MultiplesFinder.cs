using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problem1
{
    public class MultiplesFinder
    {
        private readonly List<int> _multiplesToFind;

        public MultiplesFinder(params int[] multiplesToFind)
        {
            _multiplesToFind = multiplesToFind.ToList();
        }

        public List<int> FindForLessThan(int value)
        {
            var results = new List<int>();

            for (int i = 1; i < value; i++)
            {
                if (i.IsMultipleOf(_multiplesToFind.ToArray()))
                    results.Add(i);
            }

            return results;
        }
    }

    internal static class IntExtensions
    {
        internal static bool IsMultipleOf(this int i, int value)
        {
            return i%value == 0;
        }

        internal static bool IsMultipleOf(this int value, params int[] any)
        {
            return any.Any(multiple => value.IsMultipleOf(multiple));
        }
    }
}
