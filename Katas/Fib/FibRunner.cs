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
    }
}
