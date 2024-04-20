using Xunit;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,3,5)]
        [InlineData(1,4,5)]
        public void SumTest(int n1, int n2, int sum)
        {
            // ARRANGE
            const int expectedSum = 2;

            // ACT 
            var result = Calculator.Sum(1 , 1);

            // ASSERT
            Xunit.Assert.Equal(expectedSum, result);
        }
    }
}