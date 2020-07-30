using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson_HomeWork_Example_3
{
    class Program
    {
        #region Условие
        //С клавиатуры вводятся числа,пока не будет введен 0.Подсчитать сумму всех нечетных положительных чисел
        #endregion
        #region Фамилия выполняющего
        //Фамилия выполняющего - Супрун
        #endregion
        static void Main(string[] args)
        {
            int sum = 0 ;
            while(true)
            {
                Console.Write("Введите любое число : ");
                int a = Convert.ToInt32(Console.ReadLine());
                if(a > 0)
                {
                    if(a % 2 != 0)
                    {
                        sum = sum + a;
                    }
                }
                if(a == 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Сумма всех нечетных чисел = {sum}");
            Console.ReadKey();
        }
    }
}
