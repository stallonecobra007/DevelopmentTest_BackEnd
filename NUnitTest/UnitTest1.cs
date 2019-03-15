using DevelopmentTest;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var calc = new CalculateStatistics();
            Assert.AreEqual(2, calc.Mean("1,2,3"));
        }
    }
}