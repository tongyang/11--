using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口的语法及特征
{
    class Program
    {
        static void Main(string[] args)
        {

        }


    }

    class Person : Iflyable
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void chi()
        {
            
        }

        public string he()
        {
            return "";
        }
    }

}
