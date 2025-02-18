using System;

namespace FibonacciGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declare variables:
            int number;
            int[] fibo;

            //Collect an integer from the console and validate its value:
            Console.WriteLine("Good morning, please enter the number of elements to calculate:");

            number = int.Parse(Console.ReadLine());

            //As requested, declare the minimum and maximum allowed numbers:
            while (number < 7)
            {
                Console.WriteLine("The entered number must be between 7 and 22, inclusive. Please try again:");
                number = int.Parse(Console.ReadLine());
            }

            while (number > 22)
            {
                Console.WriteLine("The entered number must be between 7 and 22, inclusive. Please try again:");
                number = int.Parse(Console.ReadLine());
            }

            //Create the Fibonacci sequence in two parts:
            //First, declare the array and define the first numbers:
            fibo = new int[number];

            if (number >= 1)
                fibo[0] = 0;

            if (number >= 2)
                fibo[1] = 1;

            //Then calculate the rest of the sequence:
            for (int i = 2; i < number; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }

            //Print the results on the screen both in normal and reverse order:
            Console.WriteLine("\nThe Fibonacci sequence numbers are:");
            for (int i = 0; i < number; i++)
            {
                Console.Write(fibo[i] + " ");
            }
            Console.WriteLine("\n\nIn reverse order they are:");
            for (int i = number - 1; i >= 0; i--)
            {
                Console.Write(fibo[i] + " ");
            }
            Console.WriteLine("\n\n");
        }
    }
}
