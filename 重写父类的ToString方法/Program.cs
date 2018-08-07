using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 重写父类的ToString方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }

        
    }

    class Person
    {
        public override string ToString()
        {
            return " ";
        }
    }
}
