/*
 * Appendix 2 - Exercise 2: Sorting an Array (Descending)
 */


using System;

namespace AIE_Assessment_Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input comma separated list of numbers");
            string lineOfText = Console.ReadLine();
            string[] values = lineOfText.Split(',');

            int[] numbers = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                numbers[i] = Int32.Parse(values[i]);
            }

            // TODO:
            // Write a function that accepts the integer array 'numbers' and outputs the sorted array to the console

            SortArrayDescending(numbers);
            
            string output = string.Join(", ", numbers);
            Console.Write(output);

        }

        static void SortArrayDescending(int[] unorderedNumbers)
        {
            if (unorderedNumbers.Length <= 1) return;

            bool sorted = false;

            while(!sorted)
            {
                sorted = true;

                for (int i = 0; i < unorderedNumbers.Length - 1; i++)
                {
                    if(unorderedNumbers[i] < unorderedNumbers[i+1])
                    {
                        int temp = unorderedNumbers[i + 1];
                        unorderedNumbers[i + 1] = unorderedNumbers[i];
                        unorderedNumbers[i] = temp;
                        sorted = false;
                    }
                }
            }
            
        }
    }
}
