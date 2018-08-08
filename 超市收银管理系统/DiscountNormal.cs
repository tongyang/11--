using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银管理系统
{
    class DiscountNormal : DiscountFather
    {
        public override double GetTotalMoney(double cust)
        {
            return cust;
        }
    }
}
