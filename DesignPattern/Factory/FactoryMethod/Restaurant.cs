using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.FactoryMethod
{
    /**
     * 抽象饭店类
     */
    abstract class Restaurant
    {
        /// <summary>
        /// 抽象食物
        /// </summary>
        /// <returns></returns>
        public abstract string Cook();

        /// <summary>
        /// 抽象酒类
        /// </summary>
        /// <returns></returns>
        public abstract string Drink();
    }
}
