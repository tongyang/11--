using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 引用类型的值传递
{
    class Person
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
    }
}
