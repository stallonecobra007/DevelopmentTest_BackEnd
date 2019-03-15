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
        public void Mean()
        {
            var calc = new CalculateStatistics();
            double result = calc.Mean("1,2,3");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Median()
        {
            var calc = new CalculateStatistics();
            double result = calc.Mean("1,2,3,4,5,6");
            Assert.AreEqual(3.5, result);
        }

        [Test]
        public void Mode()
        {
            var calc = new CalculateStatistics();
            double result = calc.Mean("1,2,3,3");
            Assert.AreEqual("3", result);
        }

    }
}