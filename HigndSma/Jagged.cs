using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigndSma
{
    class Jagged
    {
        static void Main()
        {
            string[][] names = new string[3][];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("enter the size:");
                int size = int.Parse(Console.ReadLine());
                names[i] = new string[size];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < names[i].Length; j++)
                {
                    names[i][j] =Console.ReadLine();
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < names[i].Length; j++)
                {
                    Console.Write(" " +names[i][j]);
                }
                Console.WriteLine();
            }
            foreach (string s in names[0])
                Console.WriteLine("the  row "+s);
        }

    }
}
