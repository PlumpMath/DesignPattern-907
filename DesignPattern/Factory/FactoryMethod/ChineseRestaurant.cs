using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.FactoryMethod
{
    /**
     * 中餐馆
     */
    class ChineseRestaurant : Restaurant
    {
        ChineseFood food = new ChineseFood();

        /// <summary>
        /// 做中餐
        /// </summary>
        /// <returns></returns>
        public override string Cook() 
        {
            return food.Course();
        }

        /// <summary>
        /// 上白酒
        /// </summary>
        /// <returns></returns>
        public override string Drink()
        {
            return food.Alcohol();
        }
    }
}
