using System;
using NUnit.Framework;
using ProjectEuler.Problem4;

namespace ProjectEuler.Tests.Problem4
{
    [TestFixture]
    public class Answer
    {
        [Test]
        public void FindAnswer()
        {
            var largest = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    var product = i*j;
                    if (product.IsPalindrome() && product > largest)
                        largest = product;
                }
            }

            Console.Write(largest);
        }
    }
}
