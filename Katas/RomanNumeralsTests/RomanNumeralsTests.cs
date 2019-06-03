using NUnit.Framework;
using RomanNumerals;
using System;

namespace RomanNumeralsTests
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        public RomanNumeralConverter converter = new RomanNumeralConverter();

        [Test]
        public void Should_not_recognize_zero()
        {
            var ex = Assert.Throws<Exception>(() => converter.Convert_to_numeral(0));
            Assert.That(ex.Message, Is.EqualTo("0 is not known to Roman Numerals"));
        }

        [Test]
        public void Should_recognize_non_zero()
        {
            var nonZeroNumeral = converter.Convert_to_numeral(1);
            Assert.AreEqual(nonZeroNumeral, "I");
        }

    }
}
