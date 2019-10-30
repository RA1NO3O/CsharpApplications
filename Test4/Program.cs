using System;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0 ,  x = 0;
            do
            {
                if (i % 2 == 0) { x += i; }
                i++;
            } while (i<=100);
            Console.Write(x);
        }
    }
}
