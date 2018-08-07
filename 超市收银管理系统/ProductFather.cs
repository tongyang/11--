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

        public double Count
        {
            set;
            get;
        }

        public string ID
        {
            set;
            get;
        }

        public ProductFather(double price, double count, string id)
        {
            this.Price = price;
            this.Count = count;
            this.ID = id;
        }
    }
}
