using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory.FactoryMethod.Customer customer = new Factory.FactoryMethod.Customer();
            customer.GotoEat();

            Console.ReadLine();
        }
    }
}
