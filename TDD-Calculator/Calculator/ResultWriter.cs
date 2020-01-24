using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TDDCalculator
{
    public interface IResultWriter
    {
        void WriteResult(double result);
    }
    class ResultWriter:IResultWriter
    {
        public void WriteResult(double result)
        {
            //var f = File.Create("test.txt");
            var sw = new StreamWriter(File.Create("test.txt"));
            sw.WriteLine(result);
        }
    }
}
