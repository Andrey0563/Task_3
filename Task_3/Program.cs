using System;
using System.Runtime.Intrinsics.X86;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number type int: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number type double: ");
                double b = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number type long: ");
                long c = long.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                {
                    Console.WriteLine("Write the correct number\n");
                    Main(args);
                }

                Console.WriteLine($"Exaption{ex.Message}");
            }
            Console.ReadLine();

        }
    }
}