using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    class Program
    {

        static void Main(string[] args)
        {/*
            Bike Enfield = new Bike();
            Enfield.StartEngine();
            Enfield.FillGas(5);
            Enfield.Distance(1500, 40);
            
            s.Rollno = 1;
            s.Sem = 4;
            s.Name = "sai";*/
            //s.Accept();
            Student s = new Student("sai", 23, 5, "cse");
            Student s1 = new Student();
            s1.display();
            
           
            s.display();

        }
    }
}
