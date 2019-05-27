using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int fib1 = 1;
            int fib2 = 2;
            int sum = 0;
            while (true)
            {
                if ((fib2 < 4000000) && (fib2 % 2 == 0))
                {
                    sum += fib2;
                }
                else if (fib2 > 4000000)
                {
                    break;
                }
                int temp = fib2;
                fib2 = fib1 + fib2;
                fib1 = temp;
            }
            Console.WriteLine(sum.ToString());
        }
    }
}
