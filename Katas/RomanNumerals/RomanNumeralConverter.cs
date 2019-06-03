using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        public Dictionary<int, string> numeralCardinals { get; set; }
        public RomanNumeralConverter() {
            numeralCardinals = new Dictionary<int, string>();
        }

     
        public string Convert_to_numeral(int input)
        {
            if (input == 0)
                throw new Exception("0 is not known to Roman Numerals");
            else
                return "I";
        }
    }
}
