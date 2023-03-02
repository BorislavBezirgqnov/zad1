using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Име на списъка: ");
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            PrintCount(numbers);
            Console.WriteLine("Числа на първи масив: ");
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            AddArrayToList(numbers, array1);
            Console.WriteLine("Да провери дали числото го има: ");
            int num = int.Parse(Console.ReadLine());
            IsNumInList(numbers, num);
            Console.WriteLine("Число на втори масив: ");
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            AddArrayToListTwo(numbers, array2);
        }

        private static void AddArrayToListTwo(List<int> numbers, int[] array2)
        {
            numbers.InsertRange(3, array2);
            numbers.Sort();
            Console.WriteLine($"Добавяне на втория масив към списъка с първи масив{string.Join("*",numbers)}");
        }

        private static void PrintCount(List<int> numbers)
        {
            Console.WriteLine(numbers.Count);
        }

        private static void AddArrayToList(List<int> numbers, int[] array1)
        {
            numbers.AddRange(array1);
            numbers.Sort();
            Console.WriteLine($"Добавя се първия масив към списък: {string.Join(" ",numbers)}");
        }

        private static void IsNumInList(List<int> numbers, int num)
        {
            if (numbers.Contains(num))
            {
                Console.WriteLine($"Числото {num} е на {numbers.IndexOf(num)}");
            }
            else
            {
                Console.WriteLine($"Числото {num} не е в списъка!");
            }
        }
    }
}