using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SecondLesson_HomeWork_Example1
{
    class Program
    {
        #region Условие
        //Написать метод,возращающий минимальное из трех чисел.
        #endregion
        #region Фамилия выполняющего
        //Фамилия выполняющего - Супрун
        #endregion
        static void Main(string[] args)
        {
            //int test = Min(6, 13, -4);
        }
        static int Min(int a,int b,int c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < a && b < c)
            {
                return b;
            }
            else if (c < a && c < b)
            {
                return c;
            }
            else
            {
                return 0;
            }
        }
    }
}
