using Fib;
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
        public void Returns_0th_entry()
        {
            FibRunner fibRunner = new FibRunner();
            var position = 0;
            var result = fibRunner.GenerateFibs(position);
            Assert.AreEqual(result, 0);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(35, 9227465)]
        public void Calculates_number_at_position(int position, int expected)
        {
            FibRunner fibRunner = new FibRunner();
            var result = fibRunner.GenerateFibs(position);
            Assert.AreEqual(result, expected);
        }
    }
}