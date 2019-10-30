using System;

namespace Test6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)   //直角在左下角
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", j, i, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
