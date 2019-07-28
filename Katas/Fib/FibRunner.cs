using System;
using System.Collections.Generic;
using System.Text;

namespace Fib
{
    public class FibRunner
    {
        public int GenerateFibs(int position)
        {
            if (position < 2)
                return position;
            return GenerateFibs(position - 1) + GenerateFibs(position - 2);
        }
        
        public int GenerateFibsNoRecursion(int position)
        {
            if (position < 2)
                return position;
            var output = 0;
            var previous = 1;
            var secondPrevious = 0;
            for (int i = 2; i <= position; i++)
            {
                output = previous + secondPrevious;
                secondPrevious = previous;
                previous = output;
            }
            return output;
        }
    }
}
