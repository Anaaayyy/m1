﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Проверка на четность числа 
            Console.Write("Введите целое число: ");
            int chislo = Console.Read(); 

            //проверка на четность деление на 2 и сравнивание остатка с нулем
            if (chislo % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
                Console.WriteLine("Число нечетное");
            Console.ReadKey();



        }
    }
}
