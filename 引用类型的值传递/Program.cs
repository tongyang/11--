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

            int number = 10;
            TestTwo(ref number);
            Console.WriteLine(number);
            Console.ReadKey();
        }

        public static void TestTwo(ref int n) // ref关键字把单纯的值传递变为引用传递，即将变量的地址当做参数进行传递
        {
            n++;
        }
    }
}
