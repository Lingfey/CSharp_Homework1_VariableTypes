//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу расчета объема - V и площади поверхности -S цилиндра. Объем V
//цилиндра радиусом – R и высотой – h, вычисляется по формуле: . Площадь S поверхности
//цилиндра вычисляется по формуле: S = 2πR(R + h).Результаты расчетов выведите на экран.
//Пользователь должен иметь возможность вводит r – радиус цилиндра и h – высоту цилинда.

using System;
namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = Math.PI;
            Console.WriteLine("Enter the value of the cylinder's radius");
            int r = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of the cylinder's height");
            int h = Int32.Parse(Console.ReadLine());
            double V = pi * (r * r) * h;
            double S = 2 * pi * r * (r + h);
            Console.WriteLine($"The voulume of the cylinder is equal to {V:0.0000}," +
                $"and its total surface area is equal to {S:0.0000}.");
            Console.ReadKey();

        }
    }
}