using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("1.Insert Employee Details \n 2.Display all Employee details \n 3.Update emloyeeDetails based on ID \n Delete aSpecific Employee whos id is given");
                Console.WriteLine("enter the no ");
                int n = Convert.ToInt32(Console.ReadLine());
                List<Emp> emps = new List<Emp>();
                switch (n)
                {
                    case 1:
                        //for (int i = 0; i < 1; i++)
                        //{
                        Console.WriteLine("enter the employee name:");
                        string s = Console.ReadLine();
                        Console.WriteLine("enter the empid");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the emp designatrion:");
                        string w = Console.ReadLine();
                        Console.WriteLine("");

                        emps.Add(new Emp(s, id, w));
                        Console.WriteLine("employees Are Inserted:");
                        //}
                        break;

                    case 2:
                        Console.WriteLine("display emp details:");
                        foreach(Emp e in emps)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        break;
                    case 4:

                        Console.WriteLine("Enter Employee Id to Remove...");
                        int id1 = int.Parse(Console.ReadLine());
                        List<Emp> tr = emps.FindAll(e1 => e1.Empid == id1);
                        foreach (Emp e in tr)
                        {
                            emps.Remove(e);
                        }
                        Console.WriteLine("Employee Deleted Press 2 to view Employee Details");

                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter to update 1.Name \n 2.Designation...");
                            int change = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Employee Id to Update...");
                            int id2 = int.Parse(Console.ReadLine());

                            if (change == 1)
                            {
                                List<Emp> tr1 = emps.FindAll(e2 => e2.Empid == id2);
                                Console.WriteLine("Enter Name to Change..");
                                string str = Console.ReadLine();
                                foreach (Emp e3 in tr1)
                                {
                                    e3.Name = str;
                                }
                            }
                            else if (change == 2)
                            {
                                List<Emp> tr1 = emps.FindAll(e2 => e2.Empid == id2);
                                Console.WriteLine("Enter Designation to Change..");
                                string str = Console.ReadLine();
                                foreach (Emp e3 in tr1)
                                {
                                    e3.Empdesign = str;
                                }
                            }
                            break;

                        }
                    case 5:
                        System.Environment.Exit(0);
                        break;
                }
            }
        }

    }
}
