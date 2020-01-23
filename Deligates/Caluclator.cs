using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
    class Caluclator
    {
        public static double calArea(double r)
        {
            Console.WriteLine("calArea");
            return 3.14 * r * r;
        }
        public static double calArea1(double r)
        {
            return r*10;
        }
    }
}
