using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.FactoryMethod
{
    /**
     * 西餐厅提供的食物
     */
    class WesternFood : Food
    {
        /// <summary>
        /// 牛排
        /// </summary>
        /// <returns></returns>
        public override string Course() 
        {
            return "Steak";
        }

        /// <summary>
        /// 葡萄酒
        /// </summary>
        /// <returns></returns>
        public override string Alcohol() 
        {
            return "Wine";
        }
    }
}
