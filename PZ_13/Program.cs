namespace PZ_13
{
    internal class Program
    {
        // 1
        static int arithmeticProgression(int n)
        {
            if (n == 1)
            {
                return -10;
            }
            else
            {
                return arithmeticProgression(n - 1) - 2;
            }
        }

        // 2
        static double geometricProgression(int n1, double b1, double q)
        {
            if (n1 == 1)
            {
                return b1;
            }
            else
            {
                return geometricProgression(n1 - 1, b1, q) * q;
            }
        }

        // 3
        static void number1(int A, int B)
        {
            if (A < B)
            {
                Console.WriteLine(A);
                if (A < B)
                    number1(A + 1, B);
            }
            else if (A > B)
            {
                Console.WriteLine(A);
                if (A > B)
                    number1(A - 1, B);
            }
            else
            {
                Console.WriteLine(A);
            }
        }

        // 4 (на пятерку (задача под №4)
        static void number2(int num)
        {
            if (num < 10)
                Console.Write(num);
            else
            {
                Console.Write(num % 10);
                number2(num / 10);
            }
        }

        static void Main()
        {
            // 1. вычисляем n-й член арифметической прогрессии с первым членом -10 и разностью -2
            Console.WriteLine("Введите номер члена арифметической прогрессии, который хотите вычислить: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = arithmeticProgression(n);
            Console.WriteLine("Значение {0}-го члена арифметической прогрессии: {1}", n, result);

            // 2. вычисляем n-й член геометрической прогрессии с первым членом -12 и множителем -2
            Console.WriteLine("Введите номер члена геометрической прогрессии, который хотите вычислить: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            double b1 = 12; // значение первого элемента
            double q = -2; // знаменатель прогрессии
            double result1 = geometricProgression(n1, b1, q);
            Console.WriteLine("Значение {0}-го члена геометрической прогрессии: {1}", n1, result1);

            // 3. печатаем числа от 6 до 54
            Console.WriteLine("\nВывод чисел от A до B:");
            number1(6, 54);

            // 4. обращаем число
            Console.WriteLine("Введите число:");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Перевернутое число: ");
           number2(number);
        }
    }
}