using System;
using System.Collections.Generic;
using System.Text;
using TDDCalculator;
using Xunit;
using Moq;
using System.IO;

namespace TDD_Calculator
{
    public class MockCalculatorTest
    {
        private IResultWriter _resultWriter;

        public MockCalculatorTest()
        {
            var mockCalculator = new Mock<IResultWriter>();
            mockCalculator.Setup(o => o.WriteResult(It.IsAny<double>()));
            _resultWriter = mockCalculator.Object;
        }

        [Fact]
        public void TestMultiply()
        {
            var calculator = new MockCalculator(_resultWriter);
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

        [Fact]
        public void TestException()
        {
            var mock = new Mock<IResultWriter>();
            mock.Setup(o => o.WriteResult(It.IsAny<double>())).Throws(new IOException("Disc is Full"));

            var c = new MockCalculator(mock.Object);
            Assert.Throws< IOException > (() => c.Multiply(5, 6));
        }

        
    }
}
