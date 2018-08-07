using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 部分类
{
    class Program
    {
        static void Main(string[] args)
        {

        }


    }

    

    partial class Person
    {
        public void test()
        {
            _name = "sdasd";
        }
    }
}
