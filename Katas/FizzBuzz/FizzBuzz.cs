using System;


public class FizzBuzz
{
    public FizzBuzz() { }

    public string Fizzify(int input)
    {
        if (input == 15)
            return "fizz-buzz";
        if (input % 3 == 0)
            return "fizz";
        if (input % 5 == 0)
            return "buzz";
        return input.ToString();
    }
}

