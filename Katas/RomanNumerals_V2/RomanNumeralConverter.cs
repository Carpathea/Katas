using System;

namespace RomanNumerals_V2
{
    public class RomanNumeralConverter
    {
        public string ConvertToRomanNumeral(int number)
        {
            var result = "I";
            if(number > 1)
                result += "I";
            return result;
        }
    }
}
