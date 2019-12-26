﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LembdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<int> numbers = new List<int> {5,7,10,15,12,13,255,123,32,67,43,24 };

            //List<int> oddNumbers = (from n in numbers where (n % 2) > 0 select n).ToList();
            List<int> oddNumbers = numbers.Where(n => (n % 2 > 0)).ToList();

            //List<int> evenNumbers = (from n in numbers where (n % 2) == 0 select n).ToList();
            List<int> evenNumbers = numbers.Where(n => (n % 2 == 0)).ToList();
            
            double avgNumber = numbers.Average(n => n);
            int minNumber = numbers.Min(n => n);
            int maxNumber = numbers.Max(n => n);

            Console.WriteLine($"Odd  :{string.Join(", ", oddNumbers)}");
            Console.WriteLine($"Even :{string.Join(", ", evenNumbers)}");
            Console.WriteLine($"Average : {avgNumber}, Min : {minNumber}, Max : {maxNumber}");

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
