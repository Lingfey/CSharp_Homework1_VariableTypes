//Используя Visual Studio, создайте проект по шаблону Console Application.
//Написать программу для расчета скидки за покупку, скидку и цену товара должен
//осуществлять пользователь.

using System;
namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the price");
            double price = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the discount (percentage)");
            double discount = Double.Parse(Console.ReadLine());
            double newPrice = price * ((100 - discount) / 100);
            Console.WriteLine($"Your new price is {newPrice}");
            Console.ReadKey();
        }
    }
}