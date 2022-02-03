using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsArray
{
    internal class PrintArray
    {
        public static void ToPrintArray(int[] inputArray)
        {
            foreach (int element in inputArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n - - - - - - - - - -");
        }
        public static void ToPrintArray(double[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n - - - - - - - - - -");
        }
        public static void ToPrintArray(char[] inputArray)
        {
            foreach (char element in inputArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n - - - - - - - - - -");
        }
    }
}
