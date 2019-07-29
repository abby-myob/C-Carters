using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class LeapYearCalculator
    {
        private int Year { get; }

        public LeapYearCalculator(int year)
        {
            Year = year;
        }


        public List<int> Get20LeapYears()
        {
            List<int> years = new List<int>();
            int currYear = Year;

            while (years.Count < 20)
            {
                if (DateTime.IsLeapYear(currYear))
                {
                    years.Add(currYear);
                }
                currYear++;
            }

            return years;
        }
    }
}