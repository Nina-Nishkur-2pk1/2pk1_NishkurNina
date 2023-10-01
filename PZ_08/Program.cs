using System;

namespace PZ_08
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1 и 2");
            // Создание ступенчатого массива
            int[][] array = new int[15][];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int length = random.Next(2, 10);
                array[i] = new int[length];
                for (int j = 0; j < length; j++)
                {
                    array[i][j] = random.Next(1, 45);
                }
            }

            // Вывод сгенерированного массива
            foreach (int[] row in array)
            {
                foreach (int num in row)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задание 3");
            // Создание и заполнение нового одномерного массива последними элементами каждой строки
            int[] lastElements = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                lastElements[i] = array[i][array[i].Length - 1];
            }

            // Вывод нового одномерного массива
            foreach (int num in lastElements)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Задание 4");
            // Создание и заполнение массива максимальными элементами каждой строки
            int[] maxElements = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int max = int.MinValue;
                foreach (int num in array[i])
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
                maxElements[i] = max;
            }

            // Вывод массива максимальных элементов
            foreach (int num in maxElements)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Задание 5");
            // Замена первого элемента и максимального элемента в каждой строке
            for (int i = 0; i < array.Length; i++)
            {
                int maxIndex = Array.IndexOf(array[i], maxElements[i]);
                int temp = array[i][0];
                array[i][0] = array[i][maxIndex];
                array[i][maxIndex] = temp;
            }

            // Вывод обновленного массива
            foreach (int[] row in array)
            {
                foreach (int num in row)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задание 6");
            // Реверс каждой строки ступенчатого массива
            for (int i = 0; i < array.Length; i++)
            {
                Array.Reverse(array[i]);
            }

            // Вывод массива после реверса
            foreach (int[] row in array)
            {
                foreach (int num in row)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задание 7");
            // Подсчет общего количества символов в строках каждой строки массива
            int[] charCounts = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                foreach (int num in array[i])
                {
                    charCounts[i] += num.ToString().Length;
                }
            }

            // Вывод общего количества символов в строках каждой строки массива
            foreach (int count in charCounts)
            {
                Console.WriteLine("Общее количество символов: " + count);
            }
        }
    }
}










