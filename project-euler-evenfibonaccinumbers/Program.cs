using System;

namespace project_euler_evenfibonaccinumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 2;
            int a = 1;
            int b = 2;

            while (b < 3000000)
            {
                int tempA = a;
                a = b;
                b = tempA + b;
                if (b % 2 == 0)
                    total = total + b;
                Console.WriteLine("Fibonacci: " + b);
                Console.WriteLine("Total of even: " + total);
            }
            Console.ReadLine();
        }
    }
}