using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly
{
    class Shape
    {
        int length;
        int width;
        int breadth;
        string name;
        public void Draw()
        {
            Console.WriteLine("Shape can be drawn");
        }
        public void Draw(int i)
        {
            this.length = i;
            Console.WriteLine("Shape can be drawnis line");
        }
        public void Draw(int i,int j)
        {
            this.length = i;
            this.breadth = j;
            Console.WriteLine("Shape can be drawn is rectangle");
        }
        public void Draw(int i,string name)
        {
            this.length = i;
            this.name = name;
            Console.WriteLine("Shape can be drawn is"+name);
        }



    }
}
