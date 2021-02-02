using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x = 0, y = 1, z;
            for (uint i = 0; i < 85; i++)
            {
                z = x + y;
                Console.WriteLine(z);
                x = y;
                y = z;
            }
        }
    }
}
