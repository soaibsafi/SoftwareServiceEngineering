using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCalculator
{
    public class MockCalculator
    {
        //Creating an instance of something that implements the interface.
        //The point of the interface is that it guarantees that what ever implements it will provide the methods declared within it.
        private IResultWriter _resultWriter; 

        public MockCalculator(IResultWriter resultWriter)
        {
            _resultWriter = resultWriter;
        }

        public double Multiply(double lhs, double rhs)
        {
            var result = lhs * rhs;
            _resultWriter.WriteResult(result);
            return result;
        }

        public double Devide(double lhs, double rhs)
        {
            double result;
            if (rhs == 0)
                result = double.NaN;
            else
                result = lhs / rhs;

            _resultWriter.WriteResult(result);
            return result;
        }

    }
}