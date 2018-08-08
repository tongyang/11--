using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银管理系统
{
    class StoreHouse
    {
        // 存储货物
        List<List<ProductFather>> list = new List<List<ProductFather>>();

        // 构造方法
        public StoreHouse()
        {
            // list[0] Acer电脑
            // list[1] 三星手机
            // list[2] 酱油
            // list[3] 香蕉
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strType">货物种类</param>
        /// <param name="count">货物数量</param>
        public void GetPros(string strType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        list[0].Add(new Acer(1000, "弘基笔记本", Guid.NewGuid().ToString()));
                        break;

                    case "Samsung":
                        list[1].Add(new Samsung(2000, "三星手机", Guid.NewGuid().ToString()));
                        break;

                    case "Soy":
                        list[2].Add(new Soy(10, "酱油", Guid.NewGuid().ToString()));
                        break;

                    case "Banana":
                        list[3].Add(new Banana(50, "香蕉", Guid.NewGuid().ToString()));
                        break;

                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 出货
        /// </summary>
        /// <param name="strType">货物种类</param>
        /// <param name="count">货物数量</param>
        /// <returns></returns>
        public ProductFather[] Shipment(string strType, int count)
        {
            ProductFather[] products = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        if (list[0].Count == 0)
                        {
                            Console.WriteLine("Acer笔记本库存告急！请先进货！");
                            break;
                        }
                        products[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;

                    case "Samsung":
                        if (list[1].Count == 0)
                        {
                            Console.WriteLine("三星手机库存告急！请先进货！");
                            break;
                        }
                        products[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;

                    case "Soy":
                        if (list[2].Count == 0)
                        {
                            Console.WriteLine("酱油库存告急！请先进货！");
                            break;
                        }
                        products[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;

                    case "Banana":
                        if (list[3].Count == 0)
                        {
                            Console.WriteLine("香蕉库存告急！请先进货！");
                            break;
                        }
                        products[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;

                    default:
                        break;
                }
            }
            return products;
        }

        /// <summary>
        /// 展示库存
        /// </summary>
        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("目前超市有：" + item[0].Name + "," + "\t" + item.Count + "个," + "\t" + "每个" + item[0].Price + "元,");
            }
        }
    }
}
