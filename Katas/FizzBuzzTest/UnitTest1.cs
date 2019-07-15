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
        public void Should_Return_One_When_One()
        {
            var input = 1;
            var result = fizz.Fizzify(input);
            Assert.AreEqual(result, "1");
        }
   
    }
}