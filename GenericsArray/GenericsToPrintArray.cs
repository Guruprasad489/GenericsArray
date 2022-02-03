using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsArray
{
    internal class GenericsToPrintArray
    {
        public static void ToPrintArray<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n - - - - - - - - - -");
        }
    }
}
