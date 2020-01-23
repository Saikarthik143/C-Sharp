using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements
{
    class Program
    {
        public static void EOD(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                if (j % 2 == 1)
                    Console.WriteLine(j + " is odd" +"\t");
                else
                    Console.Write(j + "is even");
            }
        }
        public static void Natural(int n)
        {
            int i;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Mul(int k)
        {
            int i, c;
            for (i = 1; i <= 20; i++)
            {
                c = k * i;
                Console.WriteLine(k+"*"+i+"="+c);
            }
        }
        /* public static string checkvow(char ch)
         {
             string res = null;
             switch(ch)
             {
                case 'a':
                 res = "vowel";
                     break;
                 case 'A':
                     res = "vowel";
                     break;
                 case 'e':
                     res = "vowel";
                     break;
                 case 'E':
                     res = "vowel";
                     break;
                 case 'i':
                     res = "vowel";
                     break;
                 case 'I':
                     res = "vowel";
                     break;
                 case 'o':
                     res = "vowel";
                     break;
                 case 'O':
                     res = "vowel";
                     break;
                 case 'u':
                     res = "vowel";
                     break;
                 case 'U':
                     res = "vowel";
                     break;
                 default:
                     res = "invalid";
                     break;
             }
             return res;
         }*/
        static void Main(string[] args)
        {
            Console.WriteLine();
            int g;
            
            Console.WriteLine("please enter your choice\n: 1 Even or odd \n 2:Natural \n 3:MUltiplication 4:Exit");
            g = Convert.ToInt32(Console.ReadLine());
            switch (g)
            {
                case 1:
                    EOD(100);
                    break;
                case 2:
                    Natural(50);
                    break;
                case 3:
                    Mul(2);
                    break;
                
                default:
                    Console.WriteLine("invalid opt");
                    break;


                    

            }
        }
    }
}
