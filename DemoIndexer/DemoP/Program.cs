using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoP
{
    class Calculator
    {
        public void add(params int[] x)
        {
            int res = 0;
            foreach (int i in x)
                res += i;
            Console.WriteLine(res);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.add(10,23,56,89,22);
        }
    }
}
