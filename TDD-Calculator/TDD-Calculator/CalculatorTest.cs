using System;
using TDDCalculator;
using Xunit;

namespace TDDCalculatorTest
{
    public class CalculatorTest
    {
        [Fact]
        public void TestMultiply()
        {
            var calculator = new Calculator();
            var res = calculator.Multiply(3, 5);
            Assert.Equal(res, 15);
        }

        [Fact]
        public void TestDevide()
        {
            var calculator = new Calculator();
            var res = calculator.Devide(25, 5);
            Assert.Equal(res, 5);
        }

        [Fact]
        public void TestDevideByZero()
        {
            var calculator = new Calculator();
            var res = calculator.Devide(25, 0);
            Assert.Equal(res, double.NaN);

        }
    }
}
