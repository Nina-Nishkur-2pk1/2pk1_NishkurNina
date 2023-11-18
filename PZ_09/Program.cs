namespace PZ_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводим строку в нотации camelCase с консоли
            Console.WriteLine("Введите строку в нотации camelCase: ");
            string str1 = Console.ReadLine();

            //Используем метод ConvertToUnderscoreNotation для преобразования введенной нами строки
            string str2 = ConvertToUnderscorenotation(str1);

            //Выводим результат в Underscore notation
            Console.WriteLine("Результат в  Underscore notation: " + str2);
        }
        static string ConvertToUnderscorenotation(string str1) // Метод для преобразования строки из camelCase в Underscore notation
        {
            string str2 = "";
            for (int i = 0; i < str1.Length; i++)
            {

                // Если символ является заглавной буквой, добавляем его к выходной строке с предыдущим символом подчеркивания и преобразованным в нижний регистр
                if (char.IsUpper(str1[i]))
                {
                    str2 += "_" + char.ToLower(str1[i]);
                }

                // В обратном случае просто добавляем символ к выходной строке
                else
                {
                    str2 += str1[i];
                }
            }
            // Удаляем все начальные и конечные символы подчеркивания, если они есть, и возвращаем результат
            return str2.Trim('_');
        }
    }

}


   