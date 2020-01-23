using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigndSma
{
    class twoDa
    {
        static void Main()
        {
            int high = 0;
            int[,] marks = new int[3, 3];
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<3;j++)
                {
                    marks[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write("the values:" + "\t" + marks[i, j]+"\t");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < 3; j++)
            {
                high = 0;
                for (int i = 0; i < 5; i++)
            {
                
                    if (marks[i, j] > high)
                    {
                        high = marks[i, j];
                    }

                    
                }
                Console.Write("the highest value:" + "\t" + high);
                Console.WriteLine();
            }
       
            /*foreach (int x in marks)
            {
                Console.WriteLine(x);
            }*/
        }

    }
}
