using System;

namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)

     
            {
               
                int[] array = { 5, 3, -1, 8, 0, -6, 1 };  // Создаем массив array со значениями { 5, 3, -1, 8, 0, -6, 1 }

            int sum = 0;   // Создаем переменную sum, которая будет хранить сумму модулей элементов

            bool negativeFound = false;   // Создаем переменную negativeFound, которая будет указывать, был ли уже найден отрицательный элемент

            for (int i = 0; i < array.Length; i++)  
            {
                   
                    if (negativeFound)
                    {
                        sum += Math.Abs(array[i]);  // Если уже был найден отрицательный элемент (negativeFound равно true), то текущий элемент прибавляется к переменной sum после применения функции Math.Abs() для получения модуля числа
                }
    
                else if (array[i] < 0)
                    {
                        negativeFound = true;  // Если текущий элемент меньше нуля (array[i] < 0),то negativeFound устанавливается в true, чтобы указать, что отрицательный элемент уже был найден
                }
            }

                Console.WriteLine("Сумма модулей элементов после первого отрицательного: " + sum); // Выводим результат - сумму модулей элементов после первого отрицательного
        }
        }

    }
