using System;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int i = 0;
            while(i <= 100)
            {
                x += i;
                i++;
            }
            Console.Write(x);
        }
    }
}
