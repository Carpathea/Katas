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
        public void Should_recognize_non_zero()
        {
            var nonZeroNumeral = converter.Convert_to_numeral(1);
            Assert.AreEqual(nonZeroNumeral, "I");
        }

        [Test]
        public void Should_create_cardinals_dictionary()
        {
            Assert.IsTrue(converter.numeralCardinals != null);
        }

        [Test]
        public void Should_add_base_numerals_to_dictionary()
        {
            var mockCardinalsDictionary = new Dictionary<int, string>();
            mockCardinalsDictionary.Add(1, "I");
            mockCardinalsDictionary.Add(5, "V");
            mockCardinalsDictionary.Add(10, "X");
            mockCardinalsDictionary.Add(50, "L");
            mockCardinalsDictionary.Add(500, "D");
            mockCardinalsDictionary.Add(1000, "M");
            CollectionAssert.AreEqual(mockCardinalsDictionary, converter.numeralCardinals);
        }
        
    }
}
