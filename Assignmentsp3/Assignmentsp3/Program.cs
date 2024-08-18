using System;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace Assignment
{
    class Question3
    {
        public static void Main(string[] args)
        {
            double fnum1, fnum2, result;
            char  operation;

            Console.WriteLine("Enter num1:");
            fnum1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            fnum2 = byte.Parse(Console.ReadLine());

            Console.WriteLine("Chose shape:");
            Console.WriteLine("p.addition");
            Console.WriteLine("q.subtraction");
            Console.WriteLine("r.product");
            Console.WriteLine("s.quotient");

            operation = Convert.ToChar(Console.ReadLine().ToLower());

            switch (operation)
            {
                case 'p':
                    result = fnum1 + fnum2;
                    Console.WriteLine(result);
                    break;

                case 'q':
                    result = fnum1 - fnum2;
                    Console.WriteLine(result);
                    break;

                case 'r':
                    result = fnum1 * fnum2;
                    Console.WriteLine(result);
                    break;

                case 's':
                    if (fnum2 != 0)
                    { 
                    result = fnum1 / fnum2;
                            Console.WriteLine(result);
                     }
                     else
                        {
                        Console.WriteLine("Not diveded by 0");
                        }
                    break;
                }

        }
    }
}
