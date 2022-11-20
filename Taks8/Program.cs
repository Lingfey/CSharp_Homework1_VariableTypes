//Используя Visual Studio, создайте проект по шаблону Console Application.
//Имеется 3 переменные типа int x = 10, y = 12, и z = 3; Выполните и рассчитайте результат
//следующих операций для этих переменных:
//x += y - x++ * z;
//z = --x - y * 5;
//y /= x + 5 % z;
//z = x++ + y * 5;
//x = y - x++ * z;

using System;
namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;
            x += y - x++ * z;
            z = --x - y * 5;
            y /= x + 5 % z;
            z = x++ + y * 5;
            x = y - x++ * z;
            Console.WriteLine($"x = {x}\ny = {y}\nz = {z}");
            Console.ReadKey();
        }
    }
}