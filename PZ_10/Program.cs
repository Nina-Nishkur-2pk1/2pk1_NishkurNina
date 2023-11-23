namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Введите ФИО студента:");
                string Namestudent = Console.ReadLine();

                Console.WriteLine("Введите количество предметов:");
                int Subjects1 = Convert.ToInt32(Console.ReadLine());

                string[] subjects = new string[Subjects1];
                int[] grades = new int[Subjects1];

                for (int i = 0; i < Subjects1; i++)
                {
                    Console.WriteLine($"Введите название предмета {i + 1}:");
                    subjects[i] = Console.ReadLine();

                    Console.WriteLine($"Введите оценку по предмету {subjects[i]}:");
                    grades[i] = Convert.ToInt32(Console.ReadLine());
                }

                double grades1 = 0;
                for (int i = 0; i < grades.Length; i++)
                {
                    grades1 += grades[i];
                }

                double grades2 = grades1 / grades.Length;

                Console.WriteLine($"Средняя успеваемость студента {Namestudent} за год: {grades2}");
            }
        }
    }
   
        }
