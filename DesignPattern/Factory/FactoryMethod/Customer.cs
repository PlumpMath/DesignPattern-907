using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.FactoryMethod
{
    /**
     * 顾客类
     */
    class Customer
    {
        public void GotoEat()
        {
            Restaurant restaurant = null;

            restaurant = new ChineseRestaurant();
            Console.WriteLine("中午去吃中餐:吃的是" + restaurant.Cook() + "喝的是" + restaurant.Drink());

            restaurant = new WesternRestaurant();
            Console.WriteLine("晚上去吃西餐:吃的是" + restaurant.Cook() + "喝的是" + restaurant.Drink());
        }
    }
}
