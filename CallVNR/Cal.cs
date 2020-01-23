using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallVNR
{
    class Cal
    {
        int val1;
        int val2;
        public int Val1 { get => val1; set => val1 = value; }
        public int Val2 { get => val2; set => val2 = value; }

        //public Cal(int val1, int val2)
        //{
        //    this.val2 = val2;
        //    this.val1 = val1;
        //}
        public int Add(int num1,int num2)
        {
            return num1 + num2;
            //Console.WriteLine("the sum is:" + (num1 + num2));
        }
        public void Subtract(int v,int y,out int sub)
        {
            sub= (v - y);
        }
        public void Swap( ref int n,ref int x,out int s1,out int s2)
        {
            int temp = n;
            n = x;
            x = temp;
            s1 = n;
            s2 = x;
            //Console.WriteLine(n);
            //Console.WriteLine(x);

        }
    }
}
