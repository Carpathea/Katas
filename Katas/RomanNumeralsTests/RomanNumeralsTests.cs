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
            Assert.AreEqual(converter.Convert_to_numeral(1), "I");
        }    
        [Test]
        public void Should_return_II_numeral_with_2_input()
        {
            Assert.AreEqual(converter.Convert_to_numeral(2), "II");
        }
        [Test]
        public void Should_return_III_numeral_with_3_input()
        {
            Assert.AreEqual(converter.Convert_to_numeral(3), "III");
        }

        public void Should_return_IV_numeral_with_4_input()
        {
            Assert.AreEqual(converter.Convert_to_numeral(4), "IV");
        }
        
    }
}
