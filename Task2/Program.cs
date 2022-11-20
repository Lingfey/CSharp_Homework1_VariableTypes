//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте константу с именем -pi (число π «пи»), создайте переменную радиус с именем – r.
//Используя формулу πR 2 , вычислите площадь круга и выведите результат на экран.

using System;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1416;
            Console.WriteLine("Enter the radius value");
            int r = Int32.Parse(Console.ReadLine());
            double circleArea = pi * (r * r);
            Console.WriteLine($"The area of the circle with the radius of " +
                $"{r} is {circleArea}");
            Console.ReadKey();

        }
    }
}