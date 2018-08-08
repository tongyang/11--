using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银管理系统
{
    abstract class DiscountFather
    {
        /// <summary>
        /// 计算打折后应付的金额
        /// </summary>
        /// <param name="cust">打折前的价格</param>
        /// <returns>打折后的价格</returns>
        public abstract double GetTotalMoney(double cust);
    }
}
