using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Demo3
    {
        static void Main()
        {
            int[] a = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("ENter a[{0}]:", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            foreach (int k in a)
                Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
