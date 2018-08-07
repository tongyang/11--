using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Iflyable bird = new Bird();
            bird.fly();
            Console.ReadKey();
        }
    }

    class Bird : Iflyable
    {
        public void fly()
        {
            Console.WriteLine("鸟会飞");
        }
        void Iflyable.fly()
        {
            Console.WriteLine("接口会飞");
        }
    }

    interface Iflyable
    {
        void fly();
    }
}
