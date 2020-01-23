using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignments
{
    class Program
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to the world of C#");
        }
        public static void Greet(String name)
        {
            Console.WriteLine("hi!" + name);
            Console.WriteLine("Welcome to the world of C#");

        }
        public static void DisplayBtw2(int a,int b)
        {
            int i;

            for(i=a;i<=b;i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void ED(int n)
        {
            if(n%2==0)
            {
                Console.WriteLine("the num is even:" + n);
            }
            else
                Console.WriteLine("the num is odd:" + n);
        }
        public static void Temp(int a)
        {
            int c;
            c = ((a - 32) * 5 )/ 9;
            Console.WriteLine("converting the temperature fahrenheit to celsis:" + c);
        }
        public static void Gst(int a,int b)
        {
            int c;
            c = a;
            double total = 0;
            switch(c)
            {
                case 1:
                    total = b * 22.5;
                    break;
                case 2:
                    total = b * 44.5;
                    break;
                case 3:
                    total = b * 9.98;
                    break;
                default:
                    Console.WriteLine("invalid opt:");
                    break;
            }
            Console.WriteLine("calucate the total amount: "+total);
        }
        public static void Series(int a)
        {
            int i;
            for(i=0;i<=a;i++)
            {
                Console.WriteLine("the squares of " +i+ " is :"+i * i);
            }
        }
        public static void Factorial(int n)
        {
            int fact = 1;
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("the factorial of given num: " + n + " is " + fact);
        }
        public static void Fib(int a)
        {
            int t1 = 0, t2 = 1, t3;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            for (int i = 0; i < a; i++)
            {
                t3 = t1 + t2;
                Console.WriteLine(t3);
                t1= t2;
                t2 = t3;
            }

        }
        public static void Mul(int k)
        {
            int i, c;
            for (i = 1; i <= 20; i++)
            {
                c = k * i;
                Console.WriteLine(k + "*" + i + "=" + c);
            }
        }
        public static void Qst12(int a,int b)
        {
            int i;

            for (i = a; i <= b; i++)
            {
                if(i%7==0)
                Console.WriteLine(i);
            }
        }
        public static void Largest(int a,int b,int c)
        {
            int i=a, j=b, k=c;
            if (i > j)
            {
                if (i > k)
                    Console.WriteLine(i);
                else
                    Console.WriteLine(k);
            }
            else
                    if (j > k)
                Console.WriteLine(j);
            else
                Console.WriteLine(k);

        }
        static void Main(string[] args)
        {
            /*  Welcome();
              Greet("karthik");
              Console.WriteLine("enter a two positive integer: ");
             int a = Convert.ToInt32(Console.ReadLine());
              int b = Convert.ToInt32(Console.ReadLine());
              DisplayBtw2(a, b);
              Console.WriteLine("enter a  positive integer to check even or odd: ");
              int c= Convert.ToInt32(Console.ReadLine());
              ED(c);
              Console.WriteLine("enter the temprature in fahrenheit: ");
              int d= Convert.ToInt32(Console.ReadLine());
              Temp(d);
              Console.WriteLine("squares from 0 to 25 : ");
              Series(25);
              Console.WriteLine("enter a positive integer : ");
              int e= Convert.ToInt32(Console.ReadLine());
              Factorial(e);
              Console.WriteLine("enter the product num: ");
              int f= Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("enter the quantity: ");
              int g= Convert.ToInt32(Console.ReadLine());
              Gst(f, g);
              Console.WriteLine("fib series upto 40: ");
              Fib(40);
              Console.WriteLine("enter a integer for multiplication table: ");
              int h = Convert.ToInt32(Console.ReadLine());
              Mul(h);
              Console.WriteLine("divisible of 7 blw 200 to 300:");
              Qst12(200, 300);*/
            Console.WriteLine("enter 3 nums:");
            int d = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());
            int v = Convert.ToInt32(Console.ReadLine());
            Largest(d, s, v);

        }
    }
}
