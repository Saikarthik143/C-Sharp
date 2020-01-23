using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    abstract class Student
    {
       protected int id;
       protected string name;
       protected int fee=10000;
        public abstract void DisplayDetails();
        public abstract void payFee();

    }
    class DayScholar : Student
    {
        int trafee;

        public override void payFee()
        {
            Console.WriteLine("enter the transport feee:");
            trafee = int.Parse(Console.ReadLine());
            int a, b, c;
            a = trafee + fee;
            Console.WriteLine("enter the total amount to pay:" + a);

            Console.WriteLine("enter the amount u are paying:");
            b = int.Parse(Console.ReadLine());
            c = a - b;
            Console.WriteLine("the remainig fee:" + c);

        }
        public override void DisplayDetails()
        {
            Console.WriteLine("the name of the student:" + this.name + "\n student id:" + this.id + "\n");
        }
    } class Hostel:Student
        {
            public override void DisplayDetails() { }
            public override void payFee()
            {
                int hosfee;
                Console.WriteLine("enter thehostel feee:");
                hosfee = int.Parse(Console.ReadLine());
                int a, b, c;
                a = hosfee + fee;
                Console.WriteLine("enter the total amount to pay:" + a);

                Console.WriteLine("enter the amount u are paying:");
                b = int.Parse(Console.ReadLine());
                c = a - b;
                Console.WriteLine("the remainig fee:" + c);

            }
        }

    }
}
