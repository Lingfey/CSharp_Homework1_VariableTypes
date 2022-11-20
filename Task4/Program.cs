//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создать программу для определения синуса угла, ввод угла должен осуществлять
//пользователь.

using System;
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the angle value");
            int angle = Int32.Parse(Console.ReadLine());
            double sine = Math.Sin(angle);
            Console.WriteLine($"The sine of {angle}° is equal to {sine}.");
            Console.ReadKey();
        }
    }
}