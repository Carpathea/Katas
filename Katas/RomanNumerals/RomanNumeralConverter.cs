using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        public RomanNumeralConverter() {
        }

        private static KeyValuePair<int, string> I = new KeyValuePair<int, string>(1, "I");


        public string Convert_to_numeral(int input)
        {
          
            if (input == 0)
                throw new Exception("0 is not known to Roman Numerals");
            else
            {
                string numeral = "";
                var mod = input / I.Key;
                numeral += string.Concat(Enumerable.Repeat(I.Value, mod));
                return numeral;
            }

        }
    }
}
