namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            Console.WriteLine("задание 1");
            Console.WriteLine("число от 10 до 70 с шагом 5");
            for (int i = 10; i <= 70; i = i + 5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



            // задание 2
            Console.WriteLine("задание 2");
            Console.WriteLine("8 символов в алфавитном порядке, начиная с Г");
            for (char i = 'Г'; i <= 'К'; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



            // задание 3
            Console.WriteLine("задание 3");
            Console.WriteLine("4 # значков в 9 строках");
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine();
                for (int v = 0; v < 4; v++)
                {
                    Console.Write('#');
                }
            }
            Console.WriteLine();



            // задание 4
            Console.WriteLine("задание 4");
            int count = 0;
            Console.WriteLine("значение от -900 до 500, кратное 4");
            for (int i = -900; i <= 500; i++)
            {

                if (i % 4 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("количество чисел кратных '4' равно " + count);
            Console.WriteLine();


            //задание 5
            Console.WriteLine("задание 5");
            int a, b;
            for (a = 5, b = 64; b - a > 23; a++, b--)
            {
                Console.WriteLine(a + " " + b);
            }

            Console.WriteLine(a + " " + b);


        }
    }
}