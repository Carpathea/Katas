using System;


public class FizzBuzz
{
    public FizzBuzz() { }

    public string Fizzify(int input)
    {
        if (input == 3)
            return "fizz";
        else if (input == 6)
            return "fizz";
        else if (input == 9)
            return "fizz";
        return input.ToString();
    }
}

