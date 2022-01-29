using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many rooms will be rented? ");
            int rooms = int.Parse(Console.ReadLine());

            Rent[] rents = new Rent[10];

            for(int i = 0; i < rooms; i++)
            {
                int num = i + 1;
                Console.WriteLine($"Rent #{num}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                rents[room] = new Rent(name, email, room);

                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms:");

            for(int i = 0;i < rents.Length; i++)
            {
                if (rents[i] != null)
                {
                    Console.WriteLine(i + ":" + rents[i].Name + "," + rents[i].Email);
                }
            }
            
        }

    }
}
