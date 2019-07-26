using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Give me a number.");
            var response = Console.ReadLine();
            var num = int.Parse(response);
            
            Console.WriteLine("Multiply(*) or Sum?(+)");
            var operation = Console.ReadLine();
            
            
            
            //logic
            ICalculator calculator;
            
            if (operation == "+")
            {
                calculator = new SumCalc();
            }
            else
            {
                calculator = new ProdCalc();
            }
            var result = calculator.Calculate(num);
            
            Console.WriteLine($"this is the result for {calculator.Operation}: {result}");
        }
    }


    internal class SumCalc : ICalculator
    {
        public string Operation => "+";

        public int Calculate(int num)
        {
            var sum = 0;
            for (var i = 1; i <= num; i++)
            {
                sum += i;
            }

            return sum;
        }
    }

    internal class ProdCalc : ICalculator
    {
        public string Operation => "*";

        public int Calculate(int num)
        {
            var sum = 1;
            for (var i = 1; i <= num; i++)
            {
                sum *= i;
            }

            return sum;
        }
    }
    
    

    internal class Calculator : ICalculator
    {
        public string Operation { get; }

        public Calculator(string operation)
        {
            Operation = operation;
        }

        public int Calculate(int num)
        {
            int sum;
            
            if (Operation == "+")
            {
                sum = 0;
                for (int i = 1; i <= num; i++)
                {
                    sum += i;
                }
            }
            else
            {
                sum = 1;
                for (int i = 1; i <= num; i++)
                {
                    sum *= i;
                }
            } 

            return sum;
        }
    }

//    internal class BulkCalculator
//    {
//        public List<int> CalculateMany(List<int> values, ICalculator calc)
//        {
//            
//        }
//    }
}