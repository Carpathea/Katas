using System;


public class FizzBuzz
{
    public FizzBuzz() { }

    public string Fizzify(int input)
    {
        if (input % 3 == 0 || input % 5 ==0)
        {
            var output = "";
            if(input % 3 == 0)
            {
                output += "fizz";
                if (input % 5 == 0)
                    output += "-buzz";
                return output;
            }
            else
            {
                return "buzz";
            }
        }
        else
        {
            return input.ToString();
        }
    }
}

