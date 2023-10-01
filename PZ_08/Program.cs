using System;

namespace PZ_08
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1 и 2");
            // Создание ступенчатого массива
            string[][] array = new string[15][];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int length = random.Next(2, 10);
                array[i] = new string[length];
                for (int j = 0; j < length; j++)
                {
                    array[i][j] = "Строка " + (i + 1) + ", элемент " + (j + 1);
                }
            }

            // Вывод сгенерированного массива
            foreach (string[] row in array)
            {
                foreach (string str in row)
                {
                    Console.Write(str + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Задание 3");
            // Создание и заполнение нового одномерного массива последними элементами каждой строки
            string[] lastElements = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                lastElements[i] = array[i][array[i].Length - 1];
            }

            // Вывод нового одномерного массива
            foreach (string str in lastElements)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Задание 4");
            // Создание и заполнение массива максимальными элементами каждой строки
            string[] maxElements = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                string max = array[i][0];
                foreach (string str in array[i])
                {
                    if (str.CompareTo(max) > 0)
                    {
                        max = str;
                    }
                }
                maxElements[i] = max;
            }

            // Вывод массива максимальных элементов
            foreach (string str in maxElements)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Задание 5");
            // Замена первого элемента и максимального элемента в каждой строке
            for (int i = 0; i < array.Length; i++)
            {
                int maxIndex = Array.IndexOf(array[i], maxElements[i]);
                string temp = array[i][0];
                array[i][0] = array[i][maxIndex];
                array[i][maxIndex] = temp;
            }

            // Вывод обновленного массива
            foreach (string[] row in array)
            {
                foreach (string str in row)
                {
                    Console.Write(str + " ");
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
            foreach (string[] row in array)
            {
                foreach (string str in row)
                {
                    Console.Write(str + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Задание 7");
            // Подсчет общего количества символов в строках каждой строки массива
            int[] charCounts = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                foreach (string str in array[i])
                {
                    charCounts[i] += str.Length;
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










