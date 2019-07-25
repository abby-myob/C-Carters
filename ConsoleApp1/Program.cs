using System;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Give me a number.");

            var response = Console.ReadLine();
            
            var num = int.Parse(response);
            
            Console.WriteLine("Do you want the Sum(+) or the product(x)?");
            response = Console.ReadLine();
            
            var sum = 0;

            if (response == "+")
            {
                for (var i = 1; i < num + 1; i++)
                {
                    sum += i;
                }
            } else if (response == "x")
            {
                sum = 1;
                for (var i = 1; i < num + 1; i++)
                {
                    sum *= i;
                }
            }
            else
            {
                Console.WriteLine("wrong choice");
                return;
                
            }
            
            Console.WriteLine(sum);


            //if (num % 5 != 0 || num % 3 != 0) return;

//            if (name == null) return;
// 
//            
//            if (String.Compare(name, "bob", StringComparison.OrdinalIgnoreCase) == 0 || String.Compare(name, "alice", StringComparison.OrdinalIgnoreCase) == 0)
//            {
//                Console.WriteLine($"Hi, {name}");
//            }
        }
    }
}