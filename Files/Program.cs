using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"E:\C#karthik\mhyfile");
            if (di.Exists == false)
                
            di.Create();
            di.CreateSubdirectory("mhyfile2");
            DirectoryInfo[] d = di.GetDirectories();
            foreach(DirectoryInfo g in d)
            {
                Console.WriteLine(g.Name + " " + g.FullName + " " + g.CreationTime);
            }
            FileInfo[] fi = di.GetFiles();
            Console.WriteLine("##############################");
            foreach (FileInfo g in fi)
            {
                Console.WriteLine(g.Name + " " + g.FullName + " " + g.CreationTime);
            }
            FileStream fs = new FileStream(@"E:\C#karthik\mhyfile\a.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter bsw = new StreamWriter(fs);
            bsw.WriteLine(" Hai Hello Namaste Karthik");
            for (int i1 = 0; i1< 2; i1++)
            {
                string s1 = Console.ReadLine();
                bsw.WriteLine(s1);

            }
            bsw.Close();
            fs.Close();
            FileStream fs1 = new FileStream(@"E:\C#karthik\mhyfile\a.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs1);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            sr.Close();
            fs1.Close();
            FileStream fs11 = new FileStream(@"E:\C#karthik\mhyfile\a.txt", FileMode.OpenOrCreate, FileAccess.Write);
                        BinaryWriter br1 = new BinaryWriter(fs11);
            int i = 10;
            char c = 'd';
            string f = "helloi";
            br1.Write(i);
            br1.Write(c);
            br1.Write(f);
            br1.Close();
            fs1.Close();
            FileStream fs2 = new FileStream(@"E:\C#karthik\mhyfile\a.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br11 = new BinaryReader(fs2);
            int x = br11.ReadInt32();
            char y = br11.ReadChar();
            string z = br11.ReadString();
            br1.Close();
            fs.Close();
            Console.WriteLine(x + " " + y + " " + z);

        }
    }
}
