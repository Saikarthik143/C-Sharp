using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Demo
    {
        static void Main()
        {
            int[] a = new int[5] { 3, 2, 4, 5, 2};
           int sum = 0;
            foreach (int i in a)
            {


               
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
