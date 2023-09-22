namespace PZ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1;
            double h = 0.5;

            Console.WriteLine("x       y");
            Console.WriteLine("_________________");

            while (x <= 4)
            {
                double y = x + 3 * Math.Pow(x, 2) - 2.5 * Math.Pow(x, 3) + 0.75 * Math.Pow(x, 4);
                Console.WriteLine($"{x}       {y}");
                x += h;
            }

        }
    }
}