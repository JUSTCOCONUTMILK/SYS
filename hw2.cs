using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Random rand = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(rand.Next(1, 101));
            }

            Console.WriteLine("Og list of numbers:");
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            
            var evenTask = FilterEvenAsync(numbers);
            var oddTask = FilterOddAsync(numbers);
            var sumTask = CalculateSumAsync(numbers);

            await Task.WhenAll(evenTask, oddTask, sumTask);

            List<int> evenNumbers = await evenTask;
            List<int> oddNumbers = await oddTask;
            int sum = await sumTask;

            Console.WriteLine("Even numbers:");
            Console.WriteLine(string.Join(", ", evenNumbers));

            Console.WriteLine("\nOdd numbers:");
            Console.WriteLine(string.Join(", ", oddNumbers));

            Console.WriteLine($"\nSum of all numbers: {sum}");
        }

        static async Task<List<int>> FilterEvenAsync(List<int> numbers)
        {
            await Task.Delay(1500); 
            return numbers.Where(n => n % 2 == 0).ToList();
        }

        static async Task<List<int>> FilterOddAsync(List<int> numbers)
        {
            await Task.Delay(1500); 
            return numbers.Where(n => n % 2 != 0).ToList();
        }

        static async Task<int> CalculateSumAsync(List<int> numbers)
        {
            await Task.Delay(1000); 
            return numbers.Sum();
        }
    }
}
