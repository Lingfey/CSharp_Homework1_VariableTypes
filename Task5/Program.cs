//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте две целочисленные переменные и выведите на экран результаты всех арифметических
//операций над этими двумя переменными.

using System;
namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={a+b}\n{a}-{b}={a-b}\n{a}x{b}={a*b}\n" +
                $"{a}/{b}={(double)a/b:0.00}");
            Console.ReadKey();
        }
    }
}