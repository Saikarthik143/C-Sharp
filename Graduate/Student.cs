using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduate
{
    abstract class Student
    {
        string name;
        double grade;
        int sid;
        public abstract Boolean IsPassed(double grade);
        public Student() { }
        public Student(string name, double gra, int sal)
        {
            this.sid = sal;
            this.grade = gra;
            this.name = name;

        }

    }
    class UnderGraduate : Student
    {
         
        public override Boolean IsPassed(double grade)
        {
            if (grade > 70)
                return true;
            else
                return false;
        }
    }
    class Graduate : Student
    {
        public override Boolean IsPassed(double grade)
        {
            if (grade > 80)
                return true;
            else
                return false;
        }
    }

    }
