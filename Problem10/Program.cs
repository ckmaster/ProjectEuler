using System;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = 2000000;
            long sum = 5;
            for (int i = 5; i < upperLimit; i+=2)
            {
                Console.WriteLine(i.ToString());
                if (IsPrime(i))
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

        static bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
