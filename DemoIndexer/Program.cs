using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIndexer
{
    class Car
    {
        int year;
        string[] name = new string[80];

        public int Year { get => year; set => year = value; }
        public string this[int x]
        {
            get
            {
                return this[x];
            }
            set
            {
                this[x] = value;
            }
        }
        public string[] Name { get => name; set => name = value; }
        public void display()
        {
            foreach (string val in name)
                Console.WriteLine(val);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Car c = new Car();
                c.Year = 2019;
                c[0] = "Karthik";
                c.display();

                //string[] ar=new string[] { "karthik","hsgs"};
            }
        }
    }
}

