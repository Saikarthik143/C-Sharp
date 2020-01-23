using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Emp
    {
        string name;
        string empdesign;
        int empid;
        public string Name { get => name; set => name = value; }
        public string Empdesign { get => empdesign; set => empdesign = value; }
        public int Empid { get => empid; set => empid = value; }

        public Emp()
        {

        }
        public Emp(string name, int empid, string empdes)
        {
            this.Name = name;
            this.Empid = empid;
            this.Empdesign = empdes;
        }
        public  override string ToString()
        {
            return this.Name + " " + this.Empid + " " + this.Empdesign;
        }

    }
}
