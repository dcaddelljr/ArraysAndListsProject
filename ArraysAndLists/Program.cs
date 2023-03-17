using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var intArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (int numbers in intArray)
            {
                if (numbers % 2 == 0)
                {
                    Console.WriteLine(numbers + " Even");
                }
                else
                {
                    Console.WriteLine(numbers + " Odd");
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("List of Even Numbers 1-10");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("List of Odd Numbers 1-10");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }
        }    
    }
}
