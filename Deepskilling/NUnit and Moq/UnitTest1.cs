using NUnit.Framework;
using CalcLibrary;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calc = null;
        }

        [Test]
        public void Add_Test()
        {
            int actual = calc.Add(10, 20);

            Assert.That(actual, Is.EqualTo(30));
        }

        [TestCase(2, 3, 5)]
        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        [TestCase(100, 200, 300)]
        public void Add_TestCases(int a, int b, int expected)
        {
            int actual = calc.Add(a, b);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Ignore("Demonstration of Ignore Attribute")]
        [Test]
        public void Ignored_Test()
        {
            Assert.Fail();
        }
    }
}
