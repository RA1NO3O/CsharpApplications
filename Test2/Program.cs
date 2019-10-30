using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数:");
            int n = int.Parse(Console.ReadLine()); ;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += 1;
                }
            }
            if (sum == 2)
            {
                Console.WriteLine(n+"是质数");
            }
            else
            {
                Console.WriteLine(n+"不是质数");
            }
        }
    }
}
