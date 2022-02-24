using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArrayGenerics
{
    internal class PrintArray
    {
        public static void toPrint<T>(T[] intArray)
        {
            foreach (T item in intArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
