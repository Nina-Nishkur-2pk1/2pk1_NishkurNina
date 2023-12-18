namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            {
                Console.WriteLine("Введите полный путь к каталогу:");
                string directoryPath = Console.ReadLine();

                if (Directory.Exists(directoryPath)) // Проверяем существование каталога
                {
                    string[] files = Directory.GetFiles(directoryPath); // Получаем список файлов в каталоге

                    foreach (string file in files)
                    {
                        try
                        {
                            using (StreamWriter writer = File.AppendText(file)) // Открываем файл для дозаписи
                            {
                                writer.WriteLine($"Файл {file} обновлен. Время создания: {File.GetCreationTime(file)}");
                            }
                            Console.WriteLine($"Файл {file} обновлен"); // Выводим сообщение об обновлении файла
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Ошибка при обновлении файла {file}: {e.Message}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Указанный каталог не существует");
                }
            }
        }


      
        }
}
