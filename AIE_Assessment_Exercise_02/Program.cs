/*
 * Appendix 1 - Exercise 2: Fibonacci
 */

using System;

namespace AIE_Assessment_Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = 0;

            if (args.Length < 1)
            {
                args = new string[] { "20" };
            }

            numberOfElements = Int32.Parse(args[0]);
            
            // TODO:
            // Write a function that will, given an integer n, calculate the first n numbers in the 
            // Fibonacci sequence given starting elements of (0, 1). 
            // Output your result to the console
           
            int[] fibSeqGen = GenFibonacciSeq(numberOfElements);

            string output = string.Join(", ", fibSeqGen);
            Console.Write(output);
        }

        static int[] GenFibonacciSeq(int n)
        {
            int[] fibSeq = new int[n];

            fibSeq[0] = 0;
            fibSeq[1] = 1;

            for(int i = 2; i < n; i++)
            {
                fibSeq[i] = fibSeq[i - 2] + fibSeq[i - 1];
            }

            return fibSeq;
        }
    }
}
