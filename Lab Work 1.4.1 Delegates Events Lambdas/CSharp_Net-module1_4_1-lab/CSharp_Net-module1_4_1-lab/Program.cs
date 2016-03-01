using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_1_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9) declare object of OnlineShop 
            OnlineShop oshop = new OnlineShop();

            // 10) declare several objects of Customer
            Customer cust1 = new Customer("Vasiliy");
            Customer cust2 = new Customer("Yasha");

            // 11) subscribe method GotNewGoods() of every Customer instance 
            // to event NewGoodsInfo of object of OnlineShop
            oshop.evGodGoods += cust1.GotNewGoods;
            oshop.evGodGoods += cust2.GotNewGoods;
            oshop.evGodGoods += cust2.GotNewGoods;

            // 12) invoke method NewGoods() of object of OnlineShop
            // discuss results
            oshop.NewGoods("hot pizza!!");
            Console.ReadLine();
        }
    }
}
