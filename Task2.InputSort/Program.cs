using System;

namespace Task2.InputSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ReadPositiveInt("Введите количество элементов: ");

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = ReadInt($"Элемент [{i}]: ");
            }

            Console.WriteLine();
            Console.WriteLine("Исходный массив:  " + string.Join(", ", numbers));

            int[] reversed = new int[n];
            for (int i = 0; i < n; i++)
            {
                reversed[i] = numbers[n - 1 - i];
            }
            Console.WriteLine("Обратный порядок: " + string.Join(", ", reversed));

            int[] sorted = (int[])numbers.Clone(); 
            Array.Sort(sorted);
            Console.WriteLine("Отсортированный:  " + string.Join(", ", sorted));

            int max = numbers[0];
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max) max = numbers[i];
                if (numbers[i] < min) min = numbers[i];
            }
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");
        }

        /// <summary>
        /// Читает целое положительное число (N > 0), повторяя запрос при ошибке.
        /// </summary>
        static int ReadPositiveInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    int value = int.Parse(Console.ReadLine() ?? "");
                    if (value <= 0)
                    {
                        Console.WriteLine("Ошибка: число должно быть больше 0. Попробуйте снова.");
                        continue;
                    }
                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введите целое число.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: число выходит за пределы диапазона int.");
                }
            }
        }

        /// <summary>
        /// Читает целое число с клавиатуры, обрабатывая FormatException и OverflowException.
        /// </summary>
        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    return int.Parse(Console.ReadLine() ?? "");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введите целое число.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: число выходит за пределы диапазона int.");
                }
            }
        }
    }
}
