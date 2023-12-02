namespace PZ_12
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double x1, y1, x2, y2;

            // Ввод значений координат точек начала и конца вектора
            Console.WriteLine("Введите координаты точки начала вектора:");
            Console.Write("x1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты точки конца вектора:");
            Console.Write("x2: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            y2 = double.Parse(Console.ReadLine());

            // Вызов метода для вычисления длины вектора
            double length = CalculateVectorLength(x1, y1, x2, y2);

            // Вывод результата
            Console.WriteLine("Длина вектора: " + length);
        }

        static double CalculateVectorLength(double x1, double y1, double x2, double y2)
        {
            // Вычисление длины вектора по формуле:  вектор |AB| = sqrt((x2 - x1)^2 +(y2-y1)^2)
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return length;
        }
    }
}