using NUnit.Framework;
using RomanNumerals;
using System;

namespace RomanNumeralsTests
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        [Test]
        public void Should_not_recognize_zero()
        {
            RomanNumeralConverter numeralConverter = new RomanNumeralConverter();
            var ex = Assert.Throws<Exception>(() => numeralConverter.Convert_to_numeral(0));
            Assert.That(ex.Message, Is.EqualTo("0 is not known to Roman Numerals"));
        }

    }
}
