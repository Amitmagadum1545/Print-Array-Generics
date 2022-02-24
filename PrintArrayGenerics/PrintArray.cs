using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArrayGenerics
{
    internal class PrintArray
    {
        public static void toPrint(int[] intArray)
        {
            foreach (int item in intArray)
            {
                Console.WriteLine(item);
            }
        }
        public static void toPrint(double[] doubleArray)
        {
            foreach (double item in doubleArray)
            {
                Console.WriteLine(item);
            }
        }
        public static void toPrint(char[] charArray)
        {
            foreach (char item in charArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
