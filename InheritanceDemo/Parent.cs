using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Parent
    {
        protected int a;
        protected string b;
        public int A
        {
            get => a;
            set => a = value;
        }
        public string B
        {
            get => b;
            set => b = value;
        }
        public void getValue(int x, string y)
        {
            this.a = x;
            this.b = y;
        }
        public void display()
        {
            Console.WriteLine(this.A + " " + this.B);
        }
    }
    class Child : Parent
    {
        int c;
        public void Calculate(int num)
        {
            c = this.a + num;
            Console.WriteLine(c);
        }
    }
    class Grand:Parent
    {
        int d;
        public void add(int nu)
        {
            this.d =  nu;
            d = a + nu;
            Console.WriteLine(d);
        }
    }
    
       
    }
namespace demo
{
    class ExChhild : InheritanceDemo.Parent
    {
        public void ExDisplay()
        {
            Console.WriteLine(this.a + " " + this.b);
        }
    }
}