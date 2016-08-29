using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.FactoryMethod
{
    /**
     * 抽象饭店提供的食物
     */
    abstract class Food
    {
        /// <summary>
        /// 菜
        /// </summary>
        /// <returns></returns>
        public abstract string Course();

        /// <summary>
        /// 酒
        /// </summary>
        /// <returns></returns>
        public abstract string Alcohol();
    }
}
