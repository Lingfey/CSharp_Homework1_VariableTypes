//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте программу для перевода метров в сантиметры (1м = 100см), ввод метров должен
//осуществлять пользователь.

using System;
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of meters");
            int meters = Int32.Parse(Console.ReadLine());
            int centimeters = meters * 100;
            Console.WriteLine($"{meters} m is equal to {centimeters} cm");
            Console.ReadKey();
        }
    }
}
