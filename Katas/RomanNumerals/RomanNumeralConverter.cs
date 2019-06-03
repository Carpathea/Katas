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
            numeralCardinals.Add(1, "I");
            numeralCardinals.Add(5, "V");
            numeralCardinals.Add(10, "X");
            numeralCardinals.Add(50, "L");
            numeralCardinals.Add(500, "D");
            numeralCardinals.Add(1000, "M");
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
