using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.FactoryMethod
{
    /**
     * 中餐厅提供的食物
     */
    class ChineseFood : Food
    {
        /// <summary>
        /// 西红柿炒鸡蛋
        /// </summary>
        /// <returns></returns>
        public override string Course() 
        {
            return "TomatoScrambledEggs";
        }

        /// <summary>
        /// 白酒
        /// </summary>
        /// <returns></returns>
        public override string Alcohol() 
        {
            return "Liquor";
        }
    }
}
