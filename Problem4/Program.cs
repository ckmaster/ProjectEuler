using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int largestPalindrome = 0;
            int product = 0;
            for (int i = 999; i > 0; i --)
            {
                for (int j = 999; j > 0; j--)
                {
                    product = i * j;
                    if (IsPalindrome(product.ToString()))
                    {
                        if (product > largestPalindrome)
                        {
                            largestPalindrome = product;
                        }
                    }
                }
            }
            Console.WriteLine(largestPalindrome.ToString());
        }

        static bool IsPalindrome(string product)
        {
            string first = product.Substring(0, product.Length / 2);
            char[] arr   = product.ToCharArray();
            Array.Reverse(arr);
            string temp   = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }
    }
}
