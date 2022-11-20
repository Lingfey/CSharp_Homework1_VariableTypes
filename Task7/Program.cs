//Используя Visual Studio, создайте проект по шаблону Windows Forms (.Net framework).
//Создайте программу для расчета возраста пользователя, по введенному им году рождения
//необходимо вывести его текущий возраст. (использовать DateTime).

using System;
namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth");
            int birthYear = Int32.Parse(Console.ReadLine());
            int currentYear = DateTime.Now.Year;
            Console.WriteLine($"Your current age is {currentYear - birthYear}");
            Console.ReadKey();
        }
    }
}