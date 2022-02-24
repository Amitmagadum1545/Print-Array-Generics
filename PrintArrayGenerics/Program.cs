using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArrayGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
            double[] doubleArray = { 1.2, 4.5, 6.5, 8.5, 89.2345688 };
            char[] charArray = { 'A', 'B', 'C', 'D' };

            PrintArray.toPrint(intArray);
            PrintArray.toPrint(doubleArray);
            PrintArray.toPrint(charArray);
        }
    }
}
