using NUnit.Framework;
using RomanNumerals;
using System;
using System.Collections.Generic;

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
        public void Should_return_I_numeral_with_1_input()
        {
            var nonZeroNumeral = converter.Convert_to_numeral(1);
            Assert.AreEqual(nonZeroNumeral, "I");
        }    
        [Test]
        public void Should_return_II_numeral_with_2_input()
        {
            var two = converter.Convert_to_numeral(2);
            Assert.AreEqual(two, "II");
        }
        [Test]
        public void Should_return_III_numeral_with_3_input()
        {
            var three = converter.Convert_to_numeral(3);
            Assert.AreEqual(three, "III");
        }
        
    }
}
