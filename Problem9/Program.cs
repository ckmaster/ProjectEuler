using System;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1000;
            int a = 0;
            int b = 0;
            int c = 0;
            for (int i = 999; i > 0; i--)
            {
                for (int j = 2; j < i; j ++)
                {
                    for (int k = 1; k < j; k++)
                    {
                        if (((k*k + j*j == i*i)) && (i + j + k == sum))
                        {
                            c = i;
                            b = j;
                            a = k;
                        }
                    }
                }
            }
            int product = a * b * c;
            Console.WriteLine(product.ToString());
        }
    }
}
