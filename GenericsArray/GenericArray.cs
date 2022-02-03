using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsArray
{
    internal class GenericArray<T>
    {
        private T[] inputArray;

        public GenericArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void ToPrintArray()
        {
            foreach (var element in inputArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n - - - - - - - - - -");
        }
    }
}
