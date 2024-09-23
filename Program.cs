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

            //формула нахождения площади круга через радиус(Квадрат можно записать как произведение числа самого на себя)
            double plosad = Math.PI * radiys * radiys;
            Console.Write("Площадь круга :"+ Math.Round(plosad, 2 ));
            Console.ReadLine();

            Console.WriteLine("******************Фамилия и имя пользователя****************************");

            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите свою фамилию: ");
            string surname = Console.ReadLine();

            Console.WriteLine($"Имя: {name}  Фамилия: {surname}");
            Console.ReadLine();

            Console.WriteLine("******************Массив****************************");

             Random rand = new Random();
            //массив из 20 случайных чисел от 1 до 100.
            int[] numbers = Enumerable.Range(0, 20).Select(_ => rand.Next(1, 101)).ToArray();
            Console.WriteLine("Массив чисел: " + string.Join(", ", numbers));
            Console.WriteLine("Минимальное значение: " + numbers.Min());
            Console.WriteLine("Максимальное значение: " + numbers.Max());

            Console.ReadLine();

            Console.WriteLine("******************Возраст для получения прав***************************");

            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine()); //строку в целое число
            if (age >= 18)
            {
                Console.WriteLine("Вы можете получить водительские права.");
            }
            else
            {
                Console.WriteLine("Вы слишком молоды для пводительских прав.");
            }
            Console.ReadKey();
        }
    }
}
