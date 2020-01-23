using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringc
{
    class Employee
    {
        string name;
        string empid;
        int sal;
        public Employee()
        {

        }
        public Employee(string name,string empid,int sal)
        {
            this.empid = empid;
            this.sal = sal;
            this.name = name;


        }
        public override string ToString()
        {
            return this.name + "\n" + this.empid + "\n" + this.sal;
        }
        public override bool Equals(object obj)
        {
            Employee temp = (Employee)obj;
            if (this.empid == temp.empid && this.name == temp.name)
                return true;
            else
                return false;
        }
    }
}
