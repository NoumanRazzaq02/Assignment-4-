using System;
using System.Diagnostics.CodeAnalysis;

namespace Assignment_3
{

    class Program
    {
        static void Main(string[] args)
          //  6.Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        {
            long sum = 0;
            long squared = 0;
            long result = 0;

            const int N = 100;

            sum = N * (N + 1) / 2;
            squared = (N * (N + 1) * (2 * N + 1)) / 6;

            result = sum * sum - squared;
            Console.WriteLine("Answer: " + result);
        }
    }
}