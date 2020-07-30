using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson_HomeWork_Example2
{
    class Program
    {
        #region Условие
        //Написать метод подсчета количества цифр числа
        #endregion
        #region Фамилия выполняющего
        //Фамилия выполняющего - Супрун
        #endregion
        static void Main(string[] args)
        {
            //int test = Number(0);
        }
        static int Number(int num)
        {
            int b = 1;
            for(int a = 1; a <= num;a = a * 10)
            {
                if (num % a >= 1)
                {
                    b++;
                }
            }
            return b;
        }
    }
}
