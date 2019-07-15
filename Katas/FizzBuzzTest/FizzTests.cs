using NUnit.Framework;

namespace FizzTests
{
    [TestFixture]
    public class FizzTests
    {
        public FizzBuzz fizz = new FizzBuzz();
        [SetUp]
        public void Setup()
        {
           
        }

        [TestCase(1,"1")]
        [TestCase(2,"2")]
        [TestCase(4, "4")]
        [TestCase(7, "7")]
        [TestCase(11, "11")]
        [TestCase(13, "13")]
        public void Should_return_input(int input, string expected)
        {
            var result = fizz.Fizzify(input);
            Assert.AreEqual(result, expected);
        }

        [TestCase(3, "fizz")]
        [TestCase(6, "fizz")]
        [TestCase(9, "fizz")]
        [TestCase(12, "fizz")]
        public void Should_return_fizz(int input, string expected)
        {
            var result = fizz.Fizzify(input);
            Assert.AreEqual(result, expected);
        }

        [TestCase(5, "buzz")]
        [TestCase(10, "buzz")]
        [TestCase(20, "buzz")]
        [TestCase(25, "buzz")]
        public void Should_return_buzz(int input, string expected)
        {
            var result = fizz.Fizzify(input);
            Assert.AreEqual(result, expected);
        }

        [TestCase(15, "fizz-buzz")]
        [TestCase(30, "fizz-buzz")]
        [TestCase(45, "fizz-buzz")]
        public void Shoud_return_fizz_buzz(int input, string expected)
        {
            var result = fizz.Fizzify(input);
            Assert.AreEqual(result, expected);
        }
    }
}