namespace PZ_11
{
    internal class Program
    {


        static void Swap(ref double x, ref double y)
        {
            double num = x; 
            x = y; 
            y = num; 
        }

        static void Main()
        {
            Console.Write("Введите значение переменной A: ");
            double A = double.Parse(Console.ReadLine());

            Console.Write("Введите значение переменной B: ");
            double B = double.Parse(Console.ReadLine());

            Console.Write("Введите значение переменной C: ");
            double C = double.Parse(Console.ReadLine());

            Console.Write("Введите значение переменной D: ");
            double D = double.Parse(Console.ReadLine());

            Swap(ref A, ref B); // меняем содержимое переменных A и B
            Swap(ref C, ref D); // меняем содержимое переменных C и D
            Swap(ref B, ref C); // меняем содержимое переменных B и C

            Console.WriteLine("Новые значения переменных: ");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("C: " + C);
            Console.WriteLine("D: " + D);
        }
    }
}