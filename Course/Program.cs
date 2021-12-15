using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario a, b;

            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            a.Name = Console.ReadLine();
            Console.Write("Salário: ");
            a.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            b.Name = Console.ReadLine();
            Console.Write("Salário: ");
            b.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = calcMedia(a.Salary, b.Salary);

            Console.WriteLine($"Salario médio: {media} ");
        }

        static double calcMedia(double salaryA, double salaryB)
        {
            return (salaryA + salaryB) / 2.0 ;
        }
    }
}
