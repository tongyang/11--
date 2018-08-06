using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            // 《C#中的23种设计模式》
            Console.WriteLine("请输出您需要的笔记本品牌：");
            string brand = Console.ReadLine();
            Notebook nb = GetNotebook(brand);
            nb.SayHello();
            Console.ReadKey();
        }

        public static Notebook GetNotebook(string brand)
        {
            Notebook nb = null;
            switch (brand)
            {
                case "Lenovo":
                    nb = new Lenovo();
                    break;
                case "Acer":
                    nb = new Acer();
                    break;

                default:
                    nb = new IBM();
                    break;
            }

            return nb;
        }
    }

    class Lenovo : Notebook
    {
        public override void SayHello()
        {
            Console.WriteLine("联想笔记本");
        }
    }

    class Acer : Notebook
    {
        public override void SayHello()
        {
            Console.WriteLine("弘基笔记本");
        }
    }

    class IBM : Notebook
    {
        public override void SayHello()
        {
            Console.WriteLine("IBM笔记本");
        }
    }
}
