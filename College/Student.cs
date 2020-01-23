using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    class Student
    {
        static string Cname = "CRR";
        int rollNo,sem;
        string name,clas,branch;
        int[] marks = new int[5];
        public Student(int rn,string n,string c,int sem,string br)
        {
            this.rollNo = rn;
            this.name = n;
            this.clas = c;
            this.sem = sem;
            this.branch = br;
            
        }
        public void DisplayResult()
        {

            int sum = 0, Flag = 0;
            Console.WriteLine("enter elements:");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("fail");
                    Flag = 1;
                    break;
                }
                else
                {
                    sum += marks[i];
                }

            }
            if (Flag == 0)
            {
                //Console.WriteLine(sum);
                int avg = (sum / 5);
                if (avg <= 50)
                    Console.WriteLine("fail" + "\t" + avg);
                else
                    Console.WriteLine("pass" + "\t" + avg);

            }
        }

        public void Display()
        {
            Console.WriteLine("the college name is:"+Cname +"\n Roll NO:"+ this.rollNo +"\n name of studebt:"+ this.name + "\n class:"+this.clas +"\n Semister:"+ this.sem +"\n" +this.branch);
        }

    }
}
