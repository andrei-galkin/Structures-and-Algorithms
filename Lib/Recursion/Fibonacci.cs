namespace Recursion
{
    public static class Fibonacci
    {
        public static int Value(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return Value(n - 1) + Value(n - 2);
        }
    }
}
