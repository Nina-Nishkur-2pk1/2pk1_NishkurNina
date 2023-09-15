namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            Console.Write("Введите число x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double s = 0.0;
            double p = 0.0;
            if (y < 0.5)

            {
                s = (x / (1 + y * x)) + 2 * y;
            }
            else if (y >= 0.5)
            {
                s = (Math.Pow(y, 2) + Math.Pow(x, 2) - Math.Cos(x + 1.5));
            }
            if (s <= 0)
            {
                p = (s / (Math.Abs(x + 3))) + ((12 * s) / (Math.Abs(Math.Pow(y, 2)) + 7)); 
            }
            else if (s > 0)
            {
                p = (x * y + 1.5 * y) / (Math.Sin(Math.PI) - s);
            }
            double q = (Math.Cos(p + s)) / (Math.Pow(y, 2) + Math.Pow(x , 2));
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("s = " + Math.Round(s, 2));
            Console.WriteLine("p = " + Math.Round(p, 2));
            Console.WriteLine("q = " + Math.Round(q, 2));

        }
    }
}