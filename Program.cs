using System;
using System.ComponentModel;
using System.Xml.Schema;

namespace mySpace
{
    class MyProgram
    {
        public static int Add(params int[] numbers)
        {
            int total = 0;

            foreach (int n in numbers) {
                total += n;
            }

            return total;
        }

        public static int Multiply(params int[] numbers)
        {
            int total = 1;

            foreach (int n in numbers) {
                total *= n;
            }

            return total;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("How many numbers should I generate?");
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = r.Next(1, 10);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine($"Total: {Add(numbers)}");
            Console.WriteLine($"Product: {Multiply(numbers)}");
        }
    }
}