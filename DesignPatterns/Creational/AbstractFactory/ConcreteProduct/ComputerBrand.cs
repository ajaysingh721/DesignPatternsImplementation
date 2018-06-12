using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteProduct
{
    using AbstractProduct;
    using Enums;

    public class Dell : IBrand
    {
        public string GetBrand()
        {
            return Brand.Dell.ToString();
        }
    }

    public class Apple : IBrand
    {
        public string GetBrand()
        {
            return Brand.Apple.ToString();
        }
    }
}
