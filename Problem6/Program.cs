using System;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfSquares = 0;
            int squareOfSums = 0;
            for (int i = 1; i < 101; i++)
            {
                sumOfSquares += i * i;
                squareOfSums += i;
            }
            squareOfSums = squareOfSums * squareOfSums;
            Console.WriteLine((squareOfSums - sumOfSquares).ToString());
        }
    }
}
