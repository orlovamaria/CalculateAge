using System;

namespace CalculateAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name - ");
            string name = Console.ReadLine();
            Console.Write("Enter your lastname - ");
            string lastname = Console.ReadLine();
            Console.Write("Enter the year of birth - ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello {name} {lastname} your age - {DateTime.Now.Year - year}");
        }
    }
}
    