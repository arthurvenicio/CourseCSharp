using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account account;

            Console.Write("Entre o número da conta: ");
            int numberAccount = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string owner = Console.ReadLine();
            Console.Write("Haverá depósitp inicial (s/n) ?");
            char option = char.Parse(Console.ReadLine());

            if (option == 's' || option == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Account(numberAccount, owner, initialBalance);
            }
            else
            {
                 account = new Account(numberAccount, owner);
            }


            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta {account.Number}, Titular: {account.Owner}, Saldo: $ {account.GetBalance().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Entre um valor para depósito: ");
            double valueA = double.Parse(Console.ReadLine());
            account.AddBalance(valueA);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine($"Conta {account.Number}, Titular: {account.Owner}, Saldo: $ {account.GetBalance().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Entre um valor para saque: ");
            double valueB = double.Parse(Console.ReadLine());
            account.RemoveBalance(valueB );

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine($"Conta {account.Number}, Titular: {account.Owner}, Saldo: $ {account.GetBalance().ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}
