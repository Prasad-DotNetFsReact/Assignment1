using System;

namespace Assign1
{
    class Quetion2
    {
        public static void Main(string[] args)
        {
            {
                int x = 56, y = 78;
                int z = x + y;
                Console.WriteLine($"Addition of {x} and {y}");
                Console.WriteLine(z);

            }
            {
                int x = 56, y = 78;
                int z = x - y;
                Console.WriteLine($"Subtraction of {x} and {y}");
                Console.WriteLine(z);

            }
            {
                int x = 56, y = 78;
                int z = x * y;
                Console.WriteLine($"product of {x} and {y}");
                Console.WriteLine(z);

            }
            {
                int x = 56, y = 78;
                double z = x / y;
                Console.WriteLine($"Quotient of {x} and {y}");
                Console.WriteLine(z);

            }
        }
    }
}