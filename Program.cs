using System;
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
            Console.WriteLine("******************Четность числа****************************");
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
            Console.ReadLine();

            Console.WriteLine("******************Нахождение площади круга****************************");

            //Плошадь круга по его радиусу
            Console.Write("Введите радиус круга: ");
            double radiys = Convert.ToDouble(Console.ReadLine());

            //формула нахаждения площади круга через радиус(Квадрат можно записать как произведение чисда самого на себя)
            double plosad = Math.PI * radiys * radiys;
            Console.WriteLine("Площадь круга :"+ Math.Round(plosad, 2 ));
            Console.ReadKey();

        }
    }
}
