using Fib;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {

        [TestCase(0,0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(35, 9227465)]
        public void Calculates_number_at_position(int position, int expected)
        {
            FibRunner fibRunner = new FibRunner();
            var result = fibRunner.GenerateFibs(position);
            Assert.That(result, Is.EqualTo(expected));
        }


        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(35, 9227465)]
        public void Calculates_number_at_pos_no_recursion(int position, int expected)
        {
            FibRunner fibRunner = new FibRunner();
            var result = fibRunner.GenerateFibsNoRecursion(position);         
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}