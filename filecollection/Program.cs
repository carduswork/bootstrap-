using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
namespace filecollection
{
    class Program
    {
        static void Main(string[] args)
        {

            //book lunyu = new book();
            //lunyu.Name = "栈";
            //Stack<book> books = new Stack<book>();
            //books.Push(lunyu);
            //Console.WriteLine(books.Pop().Name);

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(2, "字典");
            Console.WriteLine(dict[2]);

            Hashtable ht = new Hashtable();
            ht.Add(3, "哈希");
            Console.WriteLine(ht[3]);

            Console.ReadKey();
            books.Clear();
            string path = "a.txt";
            StreamWriter sw = new StreamWriter(path);
            sw.Write("写入");
            sw.Close();
            StreamReader sr = new StreamReader(path);
            Console.WriteLine(sr.ReadLine());
            using (FileStream fs=new FileStream("binary.txt",FileMode.Create))
            {
                BinaryWriter bw=new BinaryWriter(fs);
                bw.Write(3.1415926);
            }
            using (FileStream fs=new FileStream("binary.txt",FileMode.Open,FileAccess.Read))
            {
                BinaryReader br = new BinaryReader(fs);
                //br.Read();
                Console.WriteLine(br.ReadDouble().ToString());
            }
            Console.ReadKey();
        }
    }
}
