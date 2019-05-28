using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            long bigPrime = 600851475143;
            int factor = 1;
            int lastFactor = 2;

            //2 is the only even prime, handle separately
            if (bigPrime % 2 == 0)
            {
                bigPrime = bigPrime / 2;
                lastFactor = 2;
                while (bigPrime % 2 == 0)
                {
                    bigPrime = bigPrime / 2;
                }
            }
            else
            {
                lastFactor = 1;
                factor = 3;
            }

            while (bigPrime > 1)
            {
                if (bigPrime % factor == 0)
                {
                    lastFactor = factor;
                    bigPrime = bigPrime / factor;
                    while (bigPrime % factor == 0)
                    {
                        bigPrime = bigPrime / factor;
                    }
                }
                else
                {
                    factor = factor + 2;
                }
            }
            Console.WriteLine(factor.ToString());
        }
    }
}
