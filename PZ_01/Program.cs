namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите число a ");
            double a = double.Parse(Console.ReadLine()); //ввод значения с клавиатуры

            Console.WriteLine(" Введите число b ");
            double b = double.Parse(Console.ReadLine()); //ввод значения с клавиатуры

            Console.WriteLine(" Введите число c ");
            double c = double.Parse(Console.ReadLine()); //ввод значения с клавиатуры

            double num1, num2, num3, num4, num5; //делим выражение на пять частей для удобства работы с ним

            num1 = (Math.Pow(a, (b + 1))) + (Math.Pow(Math.E, (b - 1))); //вычисления

            num2 = 1 + a * (Math.Abs(b - Math.Tan(c))); //вычисления

            num3 = (1 + (Math.Abs(b - a))); //вычисления

            num4 = (Math.Pow(Math.Abs(b - a), 2)) / 2; //вычисления

            num5 = (Math.Pow((Math.Abs(b - a)), 3)) / 3; //вычисления

            double result = (num1 / num2) * num3 + num4 - num5; //создание переменной результата
            Console.WriteLine("Результат " + result); //вывод результата на экран

            Console.ReadLine();

        }
    }
}