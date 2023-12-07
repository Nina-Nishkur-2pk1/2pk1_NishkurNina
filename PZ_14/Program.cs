using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Путь к файлу
        string filePath = @"C:\Users\Пк\File\newfile.txt";

        try
        {
            // Чтение всех строк из файла
            string[] lines = File.ReadAllLines(filePath);

            // Сортировка символов в каждой строке
            string[] sortedLines = lines.Select(line => new string(line.OrderBy(c => c).ToArray())).ToArray();

            // Перезапись файла с отсортированными строками
            File.WriteAllLines(filePath, sortedLines);

            Console.WriteLine("Сортировка завершена.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
        