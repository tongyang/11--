using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace 序列号与反序列号
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //p.Name = "童扬";
            //p.Age = 30;
            //string filePath = @"C:\Users\45294\Desktop\111.txt ";
            //char[] sp = new char[] { ' ' };
            //string[] strs = filePath.Split(sp, StringSplitOptions.RemoveEmptyEntries);
            //filePath = strs.ToString();
            //using (FileStream fsWriter = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWriter, p);
            //}
            //Console.WriteLine("序列化成功");
            //Console.ReadKey();

            using (FileStream fsRead = new FileStream(@"C:\Users\45294\Desktop\111.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p = (Person)bf.Deserialize(fsRead);
            }
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.ReadKey();
        }
    }

    [Serializable]
    class Person
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

        private int _age;
    }
}
