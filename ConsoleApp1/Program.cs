using System;
using System.ComponentModel.Design;
using System.Net;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main()
        {
            var year = DateTime.Now.Year;
            var count = 0;

            while (count < 20)
            {
                if (DateTime.IsLeapYear(year))
                {
                    count++;
                    Console.WriteLine($"count: {count}, year: {year}");
                }

                year++;
            }
        }
    } 
}