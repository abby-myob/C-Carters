using System;
using System.Collections.Generic;
using ClassLibrary1;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Should_return_20_years_when_year_is_1999()
        {
            LeapYearCalculator lyc = new LeapYearCalculator(1999);

            var years = lyc.Get20LeapYears();
            
            Assert.Equal(20, years.Count);
        }
        
        [Fact]
        public void Should_return_correct_years_when_year_is_1999()
        {
            LeapYearCalculator lyc = new LeapYearCalculator(1999);

            var years = lyc.Get20LeapYears();

            var testYears = new List<int> {2000, 2004, 2008, 2012, 2016, 2020, 2024, 2028, 2032, 2036, 2040, 2044, 2048, 2052, 2056, 2060, 2064, 2068, 2072, 2076};
            
            Assert.Equal(testYears, years);

        }
    }
}