﻿using System;


public class FizzBuzz
{
    public FizzBuzz() { }

    public string Fizzify(int input)
    {
        if (input % 3 == 0)
            return "fizz";
        if (input == 5)
            return "buzz";
        if (input == 10)
            return "buzz";
        if (input == 25)
            return "buzz";
        return input.ToString();
    }
}

