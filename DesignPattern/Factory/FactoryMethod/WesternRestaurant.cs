using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.FactoryMethod
{
    /**
     * 西餐馆
     */
    class WesternRestaurant : Restaurant
    {
        WesternFood food = new WesternFood();

        /// <summary>
        /// 做西餐
        /// </summary>
        /// <returns></returns>
        public override string Cook() 
        {
            return food.Course();
        }

        /// <summary>
        /// 上葡萄酒
        /// </summary>
        /// <returns></returns>
        public override string Drink()
        {
            return food.Alcohol();
        }
    }
}
