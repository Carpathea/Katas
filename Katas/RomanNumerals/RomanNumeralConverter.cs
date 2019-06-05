using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        public RomanNumeralConverter() {
        }

     
        public string Convert_to_numeral(int input)
        {
            if (input == 0)
                throw new Exception("0 is not known to Roman Numerals");
            else if (input == 1)
                return "I";
            else
                return "II";

        }
    }
}
