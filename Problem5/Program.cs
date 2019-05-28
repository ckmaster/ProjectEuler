using System;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 20;
            while (true)
            {
                bool divisible = true;
                for (int i = 20; i > 1; i--)
                {
                    if (answer % i != 0)
                    {
                        divisible = false;
                        break;
                    }
                }
                if (!divisible)
                {
                    answer+=20;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(answer.ToString());
        }
    }
}
