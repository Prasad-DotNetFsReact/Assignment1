//display table using all loop
using System;

namespace Assignment
{
    class Question
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Using while loop");
            Console.WriteLine("Enter num:");
            int i = 1;
            int num=byte.Parse(Console.ReadLine());
            while (i <= 10)
            {
                Console.WriteLine($"{num} * {i}={num * i}");
                i++;
            }
            Console.WriteLine("Using  do-while loop");
            Console.WriteLine("Enter num:");
            int j = 1;
            int num1 = byte.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{num1} * {j}={num1 * j}");
                j++;
            }
            while (j <= 10);

            Console.WriteLine("using for loop");
            Console.WriteLine("Enter Num:");          
            int num2;
            num2 = byte.Parse(Console.ReadLine());  
  
            for(int k=1; k<=10; k++)
            {
                Console.WriteLine($"{num2} * {k}={num2 * k}");
 
            }
        }
    }
}