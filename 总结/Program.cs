using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 总结
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Duck:Iswimable
    {
        public void Swim()
        {
            Console.WriteLine("真的鸭子靠翅膀游泳");
        }
    }

    interface Iswimable
    {
        void Swim();
    }
}
