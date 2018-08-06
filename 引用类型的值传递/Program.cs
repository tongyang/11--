using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 引用类型的值传递
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "张三";
            Person p2 = p1;
            p2.Name = "李四";
            Console.WriteLine(p1.Name);
            Console.WriteLine(object.ReferenceEquals(p1, p2));
            Console.ReadKey();
        }
    }
}
