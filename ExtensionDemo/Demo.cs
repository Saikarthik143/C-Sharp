using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionDemo
{
    
        partial class ClassA//partial method can be created on partial classs
        {
        partial void setdata();//partial method dec

        public void print()
            {
                Console.WriteLine("ClassA is assigned:");
                setdata();//partial method should be private
            }
        }
    class Demo
    {
        static void Main()
        {
            ClassA obj = new ClassA();
            obj.print();
        }
    }
}
