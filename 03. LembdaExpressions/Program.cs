using System;
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

            numbers.ForEach(p => Console.WriteLine($"{p}"));

            //List<int> oddNumbers = (from n in numbers where (n % 2) > 0 select n).ToList();
            List<int> oddNumbers = numbers.Where(n => (n % 2 > 0)).ToList();

            //List<int> evenNumbers = (from n in numbers where (n % 2) == 0 select n).ToList();
            List<int> evenNumbers = numbers.Where(n => (n % 2 == 0)).ToList();
            List<int> orderedNumbers = numbers.OrderBy(n => n).ToList();
            List<int> greaterOrderedNumbers = numbers.OrderBy(n => n).Where(n => (n >= 100)).ToList();
 
            double avgNumber = numbers.Average(n => n);
            int minNumber = numbers.Min(n => n);
            int maxNumber = numbers.Max(n => n);

            Console.WriteLine($"Odd  :{string.Join(", ", oddNumbers)}");
            Console.WriteLine($"Even :{string.Join(", ", evenNumbers)}");
            Console.WriteLine($"Average : {avgNumber}, Min : {minNumber}, Max : {maxNumber}");
            Console.WriteLine($"Ordered  :{string.Join(", ", orderedNumbers)}");
            Console.WriteLine($"Greater  :{string.Join(", ", greaterOrderedNumbers)}");
            
            Pet[] pets = { new Pet { Name="Barley", Age=8 },
                   new Pet { Name="Boots", Age=4 },
                   new Pet { Name="Whiskers", Age=1 } };
            
            var orderedPets = pets.OrderBy(pet => pet.Age).Select(p => p.Name);
            Console.WriteLine($"Pets  :{string.Join(", ", orderedPets)}");
                      

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }

    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
