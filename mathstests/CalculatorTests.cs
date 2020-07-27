using System;
using maths;
using Xunit;

namespace mathstests
{
    
    public class CalculatorTests
    {
        [Fact]
        public void CalculatorTestOneAndTwoEqualsThree()
        {
            var adder = new Calculator();

            var result = adder.Add(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void CalculatorTestOneAndTwoEqualsThree()
        {
            var adder = new Calculator();

            var result = adder.Add(1, 2);

            Assert.Equal(3, result);
        }        
    }
}
