//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создать программу для определения гипотенузы прямоугольного треугольника,
//используя формулу , где с – гипотенуза, а b и a катеты прямоугольного треугольника.
//Ввод катетов должен осуществлять пользователь.

using System;
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for the cathetus A");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for the cathetus B");
            int b = Int32.Parse(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"The hypotenuse of a right-angled triangle with catheti of {a} and {b}" +
                $" is equal to {c:0.0000}");
            Console.ReadKey();
        }
    }
}