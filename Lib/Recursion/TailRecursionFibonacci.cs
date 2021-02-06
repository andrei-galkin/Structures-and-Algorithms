using System;

namespace Recursion
{
    public static class TailRecursionFibonacci
    {
        // A tail recursive function to calculate n th fibonacci number 
        public static int Value(int n)
        {
            return calculate(n, 0, 1);
        }

        public static int calculate(int n, int a, int b)
        {
            if (n == 0)
                return a;
            if (n == 1)
                return b;

            return calculate(n - 1, b, a + b);
        }
    }
}
