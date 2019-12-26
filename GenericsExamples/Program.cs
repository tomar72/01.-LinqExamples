using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = 1;
            int int2 = 3;

            Console.WriteLine($"Int1 :{int1}, Int2 :{int1}, Equal:{AreEqual(int1, int1)}");
            Console.WriteLine($"Int1 :{int1}, Int2 :{int2}, Equal:{AreEqual(int1, int2)}");
            Console.WriteLine();

            string str1 = "TEST1";
            string str2 = "TEST2";

            Console.WriteLine($"String1 :{str1}, String1 :{str1}, Equal:{AreEqual(str1, str1)}");
            Console.WriteLine($"String1 :{str1}, String1 :{str2}, Equal:{AreEqual(str1, str2)}");
            Console.WriteLine();

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();

        }

        public static bool AreEqual<T>(T item1, T item2) where T:IComparable
        {
            return item1.CompareTo(item2) == 0;
        }
    }
}
