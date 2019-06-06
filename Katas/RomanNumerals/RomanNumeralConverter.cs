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

        private Tuple<int, string>[] digits = {
        Tuple.Create (1, "I"), Tuple.Create (4, "IV") };

        public string Convert_to_numeral(int input)
        {
            if (input == 0)
                throw new Exception("0 is not known to Roman Numerals");
            else
            {
                string numeral = "";
                foreach(var digit in digits.Reverse())
                {
                    int div = input / digit.Item1;
                    numeral += string.Concat(Enumerable.Repeat(digit.Item2, div));
                    input = input % digit.Item1;
                }
                return numeral;                
            }

        }
    }
}
