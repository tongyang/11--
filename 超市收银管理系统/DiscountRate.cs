using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银管理系统
{
    /// <summary>
    /// 按折扣率打折
    /// </summary>
    class DiscountRate : DiscountFather
    {
        /// <summary>
        /// 折扣率
        /// </summary>
        public double Rate
        {
            set;
            get;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="rate">折扣率</param>
        public DiscountRate(double rate)
        {
            this.Rate = rate;
        }

        public override double GetTotalMoney(double cust)
        {
            return cust * this.Rate;
        }
    }
}
