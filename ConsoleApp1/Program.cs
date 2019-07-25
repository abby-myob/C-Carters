using System;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Give me a number between 1 and 12");

            var response = Console.ReadLine();
            
            var num = int.Parse(response);

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} * {i} = {i*num}");
            }
        }
    }
}