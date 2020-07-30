using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson_HomeWork_Example4
{
    class Program
    {
        #region Условие
        /*
        Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
        На выходе истина если прошел авторизацию,и ложь если не прошел
        (Логин: root, Password: GeekBrains)
        Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
        Программа пропускает его дальше  или не пропускает.
        C помощью цикла do while ограничить ввод пароля тремя попытками
        */
        #endregion
        #region Фамилия выполняющего
        //Фамилия выполняющего - Супрун
        #endregion
        static void Main(string[] args)
        {
            int a = 3;
            do
            {
                Console.Write("Введите логин : ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль : ");
                string password = Console.ReadLine();
                bool pass = security(login, password);
                if (pass == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
                else
                {
                    a--;
                    Console.WriteLine($"Попробуйте еще раз! У вас осталось {a} попыток");
                    continue;
                }
            }
            while (a > 0);
            if(a == 0)
            {
                Console.WriteLine("Попытки входа исчерпаны!");
            }
            Console.ReadLine();
        }
        static bool security(string login,string password)
        {
            if(login.ToLower() == "root")
            {
            if (password.ToLower() == "geekbrains")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
