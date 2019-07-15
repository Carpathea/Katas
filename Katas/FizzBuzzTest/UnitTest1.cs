using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        public FizzBuzz fizz = new FizzBuzz();
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Should_return_one_when_one()
        {
            var input = 1;
            var result = fizz.Fizzify(input);
            Assert.AreEqual(result, "1");
        }

        [Test]
        public void Should_return_two_when_two()
        {
            var input = 2;
            var result = fizz.Fizzify(input);
            Assert.AreEqual(result, "2");
        }
   
    }
}