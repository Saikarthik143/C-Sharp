using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
    public delegate void deligatePointer();
    public delegate double calAreaPointer(double x);
    //public delegate double calAreaPointer(double x);
    class Program
    {
        static void Main(string[] args)
        {

            calAreaPointer cptr = new calAreaPointer(delegate (double r) { return 3.14 * r * r; });
            // Program p = new Program();
            //// Console.WriteLine("hello world!");
            // deligatePointer mydeligate = new deligatePointer(p.print);
            // //deligatePointer mydeligate = p.print;
            // mydeligate += p.Display;//multi cast delegate
            // mydeligate();
            // mydeligate -= p.print;
            // mydeligate();
            // calAreaPointer cptr = Caluclator.calArea;

            //cptr += Caluclator.calArea1;
            //lamda expression
            //calAreaPointer cptr1 = (r => 3.14 * r * r);
            //double area = cptr(100.00);
            //Console.WriteLine(area);


            //public void print()
            //{
            //    Console.WriteLine("welcome delegate");
            //}
            //public void Display()
            //{
            //    Console.WriteLine("welcome to multi cASTING");
            //}
            // prebuild deligates func<>,Action<>,Predicate<>
            Func<double, double> f1 = (r => 3.14 * r * r);
            double area2 = f1(1);
            Console.WriteLine(area2);
            Action<string> act = (X => Console.WriteLine(X));
            act("welcoome");
            Predicate<string> pt = (y => y.Length > 3);
            Console.WriteLine(pt("kartrhik"));
            int[] array = new int[] { 1, 2, 3, 4 };
            List<string> names = new List<string>();
            names.Add("ajay");
            names.Add("karethik");
            names.Add("sai");
            int x = array.Count(x1 => x1 > 4);
            Console.WriteLine(x);
           List<string> sn= names.FindAll(y => y.Contains('i'));
            foreach(string n in sn)
            {
                Console.WriteLine(pt("kartrhik"));

            }

     

        } }

    }

