namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void BasicTests()
        {
            RoboterFactory factory = new RoboterFactory();
            Assert.AreEqual(5000, factory.CalculateScrap(new[] { 10 }, 90));
            Assert.AreEqual(3820, factory.CalculateScrap(new[] { 20, 10 }, 55));
        }
    }
}

