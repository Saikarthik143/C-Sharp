using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the grade:");
            double n = Convert.ToDouble(Console.ReadLine());
            Student st;
            st = new UnderGraduate();
            st.IsPassed(n);


        }
    }
}
