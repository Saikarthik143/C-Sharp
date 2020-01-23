using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(12, "sai", "c", 3, "cse");
            
            s.DisplayResult();
            s.Display();

        }
    }
}
