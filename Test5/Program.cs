using System;

namespace Test5
{
    class Program
    {
        static void Main(string[] args)
        {
            long f = 1;
            long result = 0;

            for (int i = 1; i <= 10; i++)
            {
                f = f * i;
                result += f;
            }
            Console.Write(result);
        }
    }
}
