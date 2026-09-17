using System;

namespace Task1.Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101); 
            }

            Console.WriteLine("Массив: " + string.Join(", ", numbers));

            long sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }

            double product = 1;
            foreach (int n in numbers)
            {
                product *= n;
            }

            int evenCount = 0;
            foreach (int n in numbers)
            {
                if (n % 2 == 0) evenCount++;
            }

            double average = (double)sum / numbers.Length;

            int greaterThanAvg = 0;
            foreach (int n in numbers)
            {
                if (n > average) greaterThanAvg++;
            }

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product:E2}");
            Console.WriteLine($"Чётных чисел: {evenCount}");
            Console.WriteLine($"Больше среднего ({average:F1}): {greaterThanAvg}");
        }
    }
}