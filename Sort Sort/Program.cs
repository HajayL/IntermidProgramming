using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Sort
{
    internal class Program
    {
        static private Random rnd = new Random();

        static void Main(string[] args)
        {
            int[] intArray = new int[0];

            Fill(ref intArray, GetValue("Give me the array length"), GetValue("Give me the upper limit"));

            BubbleSort(intArray);

            Console.Write("Press any key to close ");
            Console.ReadKey(true);

        }

        static private int GetValue(string prompt)
        {
            int result;

            Console.Write(prompt+": ");

            while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
            {
                Console.WriteLine("Result is not valid, must be an integer & greater than 0!\n");
                Console.Write(prompt + ": ");
            }

            return result;
        }

        static private void Fill(ref int[] array, int length, int upper)
        {
            array = new int[length];

            for (int index = 0; index < length; index++)
            {
                array[index] = rnd.Next(0, upper + 1);
            }
        }

        static private void Swap(ref int a, ref int b) { int temp = a; a = b; b = temp; }

        static private void BubbleSort(int[] array)
        {
            int iteration = 0;

            for (int pass = 0; pass < array.Length - 1; pass++)
            {
                for (int index = 0; index < array.Length - 1 - pass; index++)
                {
                    if (array[index] < array[index + 1])
                    {
                        Swap(ref array[index], ref array[index + 1]);
                    }

                    iteration++;
                }
            }

            foreach (int num in array)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("{0} Iterations", iteration);
        }
    }
}
