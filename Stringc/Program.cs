using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stringc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a = new int[] { 1, 2, 3 };
                Console.WriteLine(a[9]);
                try
                {

                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine(n / 0);
                }

                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message + "  " + e.Source);
                }

            
            catch (IndexOutOfRangeException y)
            {
                Console.WriteLine("inner" + y.Message);
            }

        }

            
           
            catch (FormatException d)
            {
                Console.WriteLine(d.Message);
            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message + "  " + f.Source);

            }
            finally
            {
                Console.WriteLine("invalid");
            }
            
            /* string str = "karthik";
             Console.WriteLine(str.Length + " " + str.Substring(0, 1) + " " + str.Replace("d", "k"));
             Console.WriteLine(str.Contains("kar"));
             Console.WriteLine(String.Compare("Hello", "Hello"));
             string str2 = "KARTHIK";
             Console.WriteLine(str.Equals(str2, StringComparison.InvariantCultureIgnoreCase));
             string input = Console.ReadLine();
             string[]
            int[] ix = new int[] { 1, 2, 3, 4 };
            Employee[] eArray = new Employee[3] { new Employee("sai", "123sd", 34) , new Employee("Karthik", "156sd", 134) , new Employee("dhasd", "12sd", 344) };
            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee("hari", "123", 567));
            elist.Add(new Employee("vdbshjasi", "1673", 967));

            foreach (var v in eArray)
            {
                Console.WriteLine(v.ToString());
            }
            foreach (var v in elist)
            {
                Console.WriteLine(v.ToString());
            }
            //how to check two obj are same
            Employee e1 = new Employee("Krthik", "156sd", 134);
            Employee e2 = new Employee("Karthik", "156sd", 134);
            if (e1.Equals(e2))
            {
                Console.WriteLine("both are same ");
            }
            else
                Console.WriteLine("not same");*/
        }
    }
}
