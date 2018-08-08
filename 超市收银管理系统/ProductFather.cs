using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银管理系统
{
    class ProductFather
    {
        public double Price
        {
            set;
            get;
        }

        public string Name
        {
            set;
            get;
        }

        public string ID
        {
            set;
            get;
        }

        public ProductFather(double price, string name, string id)
        {
            this.Price = price;
            this.Name = name;
            this.ID = id;
        }
    }
}
