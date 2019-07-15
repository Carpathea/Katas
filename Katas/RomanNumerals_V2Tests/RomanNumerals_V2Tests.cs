using NUnit.Framework;
using RomanNumerals_V2;
using System;

namespace RomanNumerals_V2Tests
{
    [TestFixture]
    public class RomanNumerals_V2Tests
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        public void Should_convert_to_numeral(int number, string expected)
        {
            Assert.That(new RomanNumeralConverter().ConvertToRomanNumeral(number), Is.EqualTo(expected));
        }
    }
}
