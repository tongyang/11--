using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 密封类
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    sealed class Person : Student, Idunkable
    {
        public void Dunk()
        {
            Console.WriteLine("灌篮");
        }
    }

    class Student 
    {

    }

    public interface Idunkable
    {
        void Dunk();
    }
}
