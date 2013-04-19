using System;
using NUnit.Framework;
using ProjectEuler.Problem5;

namespace ProjectEuler.Tests.Problem5
{
    public class Answer
    {
        [Test]
        public void SmallestPositive_EvenlyDivisible_By1to20()
        {
            var check = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            for (int i = 20; i < int.MaxValue; i += 20) // Make the steps as big as possible.
            {
                if (i.IsEvenlyDivisible(check))
                {
                    Console.WriteLine("The Answer Is: '{0}'", i);
                    break;
                }
            }
        }
    }
}
