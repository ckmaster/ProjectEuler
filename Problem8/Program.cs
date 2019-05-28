using System;
using System.Collections.Generic;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            long largestProduct = 0;
            BigNumber bigNumber = new BigNumber();
            List<char> arr = new List<char>();
            arr.AddRange(bigNumber.value);
            for (int i = 0; i < arr.Count; i++)
            {
                if (Char.IsWhiteSpace(arr[i]))
                {
                    arr.Remove(arr[i]);
                }
            }
            for (int i = 0; i < arr.Count - 12; i++)
            {
                long product = 1;
                for (int j = 0; j < 13; j++)
                {
                    product *= (int)Char.GetNumericValue(arr[i + j]);
                }
                if (product > largestProduct)
                {
                    largestProduct = product;
                }
            }
            Console.WriteLine(largestProduct.ToString());
        }
    }
}
