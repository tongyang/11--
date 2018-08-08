using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银管理系统
{
    class SuperMarket
    {
        StoreHouse sh = new StoreHouse();
        public SuperMarket()
        {
            sh.GetPros("Acer", 1000);
            sh.GetPros("Samsung", 1000);
            sh.GetPros("Soy", 1000);
            sh.GetPros("Banana", 1000);
        }
        /// <summary>
        /// 跟用户交互的过程
        /// </summary>
        public void Askbuying()
        {
            Console.WriteLine("欢迎光临，请问您需要些什么？");
            Console.WriteLine("我们有弘基笔记本、三星手机、酱油和香蕉");
            string strType = Console.ReadLine();
            Console.WriteLine("您需要多少？");
            int count = Convert.ToInt32(Console.ReadLine());
            // 去仓库取货物
            ProductFather[] pros = sh.Shipment(strType, count);
            // 计算价格
            double cust = GetMoney(pros);
            Console.WriteLine("您好，一共{0}元钱", cust);
            Console.WriteLine("请选择您的打折方式 1--不打折  2--打九折  3--打85折  4--买300送50  5--买500送100");
            string input = Console.ReadLine();
            DiscountFather dis = GetDiscount(input);
            double totalMoney = dis.GetTotalMoney(cust);
            Console.WriteLine("打折后，您应付{0}元", totalMoney);
            PrintSumary(pros);
        }
        public void PrintSumary(ProductFather[] pros)
        {
            foreach (ProductFather item in pros)
            {
                Console.WriteLine("货物名称：" + item.Name + "," + "\t" + "货物单价：" + item.Price + "," + "\t" + "货物编号：" + item.ID);
            }
        }
        /// <summary>
        /// 根据用户的选择的打折方式返回一个打折方式
        /// </summary>
        /// <param name="input">用户的选择</param>
        /// <returns>打折对象</returns>
        public DiscountFather GetDiscount(string input)
        {
            DiscountFather dis = null;
            switch (input)
            {
                case "1":
                    dis = new DiscountNormal();
                    break;

                case "2":
                    dis = new DiscountRate(0.9);
                    break;

                case "3":
                    dis = new DiscountRate(0.85);
                    break;
                case "4":
                    dis = new DiscountGift(50, 300);
                    break;
                case "5":
                    dis = new DiscountGift(100, 500);
                    break;
                default:

                    break;
            }
            return dis;
        }
        /// <summary>
        /// 计算价格
        /// </summary>
        /// <param name="pros"></param>
        /// <returns></returns>
        public double GetMoney(ProductFather[] pros)
        {
            double cust = 0;
            foreach (ProductFather item in pros)
            {
                cust += item.Price;
            }
            return cust;
        }

        public void ShowPros()
        {
            sh.ShowPros();
        }
    }
}
