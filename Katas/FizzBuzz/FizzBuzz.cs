using System;


public class FizzBuzz
{
    public FizzBuzz() { }

    public string Fizzify(int input)
    {
        if (input == 3)
            return "fizz";
        return input.ToString();
    }
}

