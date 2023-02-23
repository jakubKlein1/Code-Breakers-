namespace CodeFights
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Challenge_Bonus
    {
        [Test]
        public void SchroedingerTestCase()
        {
            /*
             * Should pass!
             */
            bool SCHROEDINGER = (SCHROEDINGER == true && SCHROEDINGER == false);
            Assert.IsTrue(SCHROEDINGER);
        }
    }
}