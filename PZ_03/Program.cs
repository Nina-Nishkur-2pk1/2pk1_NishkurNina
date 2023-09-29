namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Выберите тип аккаунта: ");
            string typeAccount = Console.ReadLine().ToLower();
            string login, password, email, bankData;
            switch (typeAccount)
            {
                case "временный":
                    Console.Write("Введите логин: ");
                    login = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    password = Console.ReadLine();
                    break;
                case "стандартный":
                    Console.Write("Введите логин: ");
                    login = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    password = Console.ReadLine();
                    Console.Write("Введите привязанную почту: ");
                    email = Console.ReadLine();
                    break;
                case "золотой":
                    Console.Write("Введите логин: ");
                    login = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    password = Console.ReadLine();
                    Console.Write("Введите привязанную почту: ");
                    email = Console.ReadLine();
                    Console.Write("Введите номер банковской карты: ");
                    bankData = Console.ReadLine();
                    break; 
             default:
                    Console.WriteLine("Вы выбрали неверный тип аккаунта!");
                    break;
            }
        }
    }
}