using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Concept\n");

            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Console.WriteLine("Please choose an option\n");
            Console.WriteLine("\n1. Print array (Normal Method) \n2. Print array (Generic Method) \n3. Print array (Generic Class)");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    PrintArray.ToPrintArray(intArray);
                    PrintArray.ToPrintArray(doubleArray);         
                    PrintArray.ToPrintArray(charArray);
                    break;
                case 2:
                    GenericsToPrintArray.ToPrintArray<int>(intArray);
                    GenericsToPrintArray.ToPrintArray<double>(doubleArray);
                    GenericsToPrintArray.ToPrintArray<char>(charArray);
                    break;
                case 3:
                    new GenericArray<int>(intArray).ToPrintArray();
                    new GenericArray<double>(doubleArray).ToPrintArray();
                    new GenericArray<char>(charArray).ToPrintArray();
                    break;
                default:
                    Console.WriteLine("Please choose the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
