using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银管理系统
{
    class DiscountGift : DiscountFather
    {
        /// <summary>
        /// 赠送的金额
        /// </summary>
        public double GiftMoney
        {
            set;
            get;
        }
        /// <summary>
        /// 达标的金额
        /// </summary>
        public double TargetMoney
        {
            set;
            get;
        }

        public DiscountGift(double giftMoney, double targetMoney)
        {
            this.GiftMoney = giftMoney;
            this.TargetMoney = targetMoney;
        }

        public override double GetTotalMoney(double cust)
        {
            if (cust >= this.TargetMoney)
            {
                int temp = (int)(cust / this.TargetMoney);
                return cust - this.GiftMoney * temp;
            }
            else
            {
                return cust;
            }
        }
    }
}
