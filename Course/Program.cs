using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            a.Name = Console.ReadLine();
            Console.Write("Idade: ");
            a.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            b.Name = Console.ReadLine();
            Console.Write("Idade: ");
            b.Age = int.Parse(Console.ReadLine());

            if (a.Age > b.Age) Console.WriteLine($"Pessoa mais velha: {a.Name}");
            else Console.WriteLine($"Pessoa mais velha: {b.Name}");
        }
    }
}
