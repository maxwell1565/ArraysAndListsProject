using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10
            int[] numbers = new int[10];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            numbers[5] = 6;
            numbers[6] = 7;
            numbers[7] = 8;
            numbers[8] = 9;
            numbers[9] = 10;

            /* Create a list of type int
             * Name the list "evens"
             */
            List<int> evens = new List<int>();


            /* Create another list of type int
             * Name the list "odds"
             */
            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
            * iterate through the array you populated with 10 numbers.
            * Inside the scope of the loop,
            * check to see if each number in the array is even or odd.
            * If the number is even, add it to the evens list.
            * If the number is odd, add it to the odds list.
            */
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
                else
                {
                    odds.Add(numbers[i]);
                }
            }


            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */
            foreach (var num in evens)
            {
                Console.WriteLine(num);
            }

            /* Using a for loop,
             * display the numbers in your "odds" list
             */
            foreach (var num in odds)
            {
                Console.WriteLine(num);
            }
        }
    }
}
