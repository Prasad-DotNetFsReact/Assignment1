//print odd number
using System;

namespace Assignment
{
    class Question
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Using while loop");
            int i = 1;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
            {
                Console.WriteLine("Using do- while loop");
                int n = 1;
                do
                {
                    Console.WriteLine(n);
                    n = n + 2;
                }
                while (n <= 20);
            }

            Console.WriteLine("Using for loop");
            for (int l = 1; l <= 20; l += 2)
            {
                Console.WriteLine(l);

            }
        }
    }

}