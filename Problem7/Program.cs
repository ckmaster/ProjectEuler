using System;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeCounter = 0;
            int primeNumber = 2;
            while (primeCounter < 10001)
            {
                bool isPrime = true;
                for (int i = 2; i < primeNumber; i++)
                {
                    if (primeNumber % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeCounter++;
                    Console.WriteLine(primeNumber.ToString());
                }
                primeNumber++;
            }
            Console.WriteLine((primeNumber - 1).ToString());
        }
    }
}
