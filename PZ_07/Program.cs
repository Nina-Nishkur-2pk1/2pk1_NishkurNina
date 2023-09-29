namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n; // размерность матрицы
            Console.Write("Введите размерность квадратной матрицы: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, n]; // создание квадратной матрицы

           
            Random random = new Random(); // заполнение матрицы случайными значениями
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(-10, 10); // случайное число от -10 до 10
                }
            }

            
            Console.WriteLine("Матрица:");  // вывод матрицы на экран
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int countNegative = 0; // счетчик отрицательных элементов

            // подсчет отрицательных элементов под главной диагональю
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        countNegative++;
                    }
                }
            }

            Console.WriteLine("Количество отрицательных элементов под главной диагональю: " + countNegative);

            Console.ReadLine();
        }
    }
}


       

