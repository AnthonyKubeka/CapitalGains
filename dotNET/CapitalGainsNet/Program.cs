using System;
using System.Collections.Generic;

namespace CapitalGainsNet
{
    class Program
    {
        public static string ReadDepth()
        {
            Console.WriteLine("How deep do you want to generate the Fibonacci sequence?");
            return Console.ReadLine();
        }

        public static IEnumerable<int> GenerateFibonacciSequence(int depth){
            int previousNumber = -1; 
            int nextNumber = 1;
        
            IList<int> fibonacciSequence  = new List<int>();

            for (int counter = 0; counter < depth; counter++)
            {
                int sumTotal = previousNumber + nextNumber;
                nextNumber = previousNumber;
                previousNumber = sumTotal;
                yield return Math.Abs(sumTotal); //this just adds sumTotal to the list returned by the enumerable
            }
        }

        public static void PrintFibonacciSequence(IEnumerable<int> sequence){
            Console.WriteLine($"The generated Fibonacci sequence is: ");
            foreach (var value in sequence)
            {
                Console.WriteLine(value);
            };
        }

        static void Main(string[] args)
        {
            int depth = 0;
            bool integerProvided = false;
            
            while (!integerProvided)
            {
                var userInput = ReadDepth();
                integerProvided = Int32.TryParse(userInput, out depth);
                if (depth == 0)
                {
                    Console.WriteLine($"A non-numerical value was entered. Please enter a numerical value. {Environment.NewLine}");
                }

                IEnumerable<int> fibonacciSequence = GenerateFibonacciSequence(depth);
                PrintFibonacciSequence(fibonacciSequence);
            }
        }
        
        
    }
}
