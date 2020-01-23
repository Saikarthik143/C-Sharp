using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            
                al.Add(5);
            al.Add(4);
            al.Add("sai");
            al.Add(23.23);
            al.Remove("sai");
       
            foreach (var val in al) Console.WriteLine(val);
            Console.WriteLine();
            Queue q = new Queue();
            q.Enqueue("sai");
            q.Enqueue("hai");
            q.Enqueue(23);
            q.Enqueue(2.34);
           Console.WriteLine( q.Dequeue());
            foreach (var val in q) Console.WriteLine(val);
            Console.WriteLine();
            Stack st = new Stack();
            st.Push("hai");
            st.Push(19.23);
            st.Push(34);
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());
            foreach(var val in st) Console.WriteLine(val);
            Hashtable ht = new Hashtable();
            ht.Add(1, "cts");
            ht.Add('a', 1000);
            ht.Add("t1", 34);
            foreach(var val in ht.Keys)
            {
                Console.WriteLine(val);
                Console.WriteLine(ht[val]);
            }
        }
    }
}
