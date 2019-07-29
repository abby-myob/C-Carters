using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main()
        {

            LeapYearCalculator leapYearCalculator = new LeapYearCalculator(2019);

            List<int> leapYears = leapYearCalculator.Get20LeapYears();

            foreach (var year in leapYears)
            {
                Console.WriteLine($"This is a leap year {year}");
            }

        }
    }
}