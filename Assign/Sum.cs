using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    class Sum
    {
        static void Main()
        {
            int[][] sum = new int[2][];
            for(int i=0;i<2;i++)
            {
                int size;
                Console.WriteLine("enter the size");
                 size= Convert.ToInt32(Console.ReadLine());
                sum[i] = new int[size];
            }
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<sum[i].Length;j++)
                {
                    sum[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < sum[i].Length; j++)
                {
                    Console.WriteLine(sum[i][j]);
                }
            }
        }
    }
}
