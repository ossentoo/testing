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
        public void CalculatorTestTwoAndThreeEqualsFive()
        {
            var adder = new Calculator();

            var result = adder.Add(2, 3);

            Assert.Equal(5, result);
        }

        [Fact]
        public void CalculatorTestThreeAndFourEqualsSeven()
        {
            var adder = new Calculator();

            var result = adder.Add(3, 4);

            Assert.Equal(7, result);
        }

        [Fact]
        public void CalculatorTestInvalidValues()
        {
            var adder = new Calculator();

            string value = "A";

            int.TryParse(value, out int t);
            var result = adder.Add(t, 0);

            Assert.Throws<ArgumentException>(() => "unexpected value");
        }
    }
}
