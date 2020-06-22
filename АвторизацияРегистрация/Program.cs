using System;
using System.IO;
using System.Text;

namespace АвторизацияРегистрация
{
    class Program
    {
        static void Main(string[] args)
        {
            string username1, password1;
            Console.WriteLine("Регистрация - 0;");
            Console.WriteLine("Авторизация - 1;");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("Введите логин");
                string username = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string password = Console.ReadLine();

                FileStream file1 = new FileStream("C:\\TEST.txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(file1);
                writer.WriteLine(username);
                writer.WriteLine(password);
                writer.Close();
            }
            else
            {
                Console.WriteLine("Введите логин");
                string username = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string password = Console.ReadLine();

                FileStream file2 = new FileStream("C:\\TEST.txt", FileMode.Create);
                StreamReader reader = new StreamReader(file2);
                username1 = reader.ReadLine();
                password1 = reader.ReadLine();
                reader.Close();

                if (username == username1 && password == password1)
                {
                    Console.WriteLine("Вход выполнен успешно");
                }
                else
                {
                    Console.WriteLine("Вход не выполнен");
                }
            }

        }
    }
}
