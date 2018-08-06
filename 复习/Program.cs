using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 复习
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\45294\Desktop\2.txt", true))
            {
                string s = "sadasdadsa";
                char[] buffer = s.ToCharArray();
                sw.WriteLine(buffer);
            }
        }
    }
}
