using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Generic
    {
        static void Main()
        {
            List<int> lis = new List<int>();
            lis.Add(10);
            lis.Add('k');
            lis.Add(12);
            foreach(int r in lis)
            {
                Console.WriteLine(r);
            }
            Queue<string> qs = new Queue<string>();
            qs.Enqueue("qw");
            qs.Enqueue("223");
            qs.Enqueue("asdfws");
          qs.Dequeue();
            foreach (var b in qs) Console.WriteLine(b);
            Stack<float> sf = new Stack<float>();
            sf.Push(23.45f);
            sf.Push(54.2f);
            // Console.WriteLine(sf.Pop());
            sf.Peek();
           foreach(float i in sf) Console.WriteLine(i);
            Dictionary<int, string> dt = new Dictionary<int, string>();
                dt.Add(1, "sai");
            dt.Add(2, "karthik");
            dt.Add(3, "123");
            //dt.Add(2, "09");
            foreach(KeyValuePair<int,string> k1 in dt)
            {
                Console.Write(k1.Key);
                Console.WriteLine(k1.Value);
            }
        }
    }
}