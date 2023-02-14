/*
You are given a positive ingeter. Your task is to return multiplicative persistence: https://en.wikipedia.org/wiki/Persistence_of_a_number.

Long story short: number of times you need to multiply the digits in a given number until you reach a single digit. Examples:

num = 10 
res = 1
explanation: 1•0 = 0, which is a single digit number

num = 963
res = 3
explanation: 9*6*3 = 162 -> 1*6*2 = 12 -> 1*2 = 2, which is a single digit number

Refer to the unit tests to grasp the idea of this task.
Feel free to add as many unit tests as you want.
No external dependencies!
*/

namespace CodeFights
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class Challenge_5
    {
        [Test]
        public void PersistenceTestCase()
        {
            Assert.AreEqual(2, PersistenceSolution(25));
            Assert.AreEqual(4, PersistenceSolution(999));
        }

        public static int PersistenceSolution(long n)
        {
            /*
             * Returns persistence of a number
             */

            return 0;
        }
    }
}