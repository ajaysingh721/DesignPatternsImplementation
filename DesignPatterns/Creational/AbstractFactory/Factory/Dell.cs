using DesignPatterns.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Factory
{
    public class Dell : IBrand
    {
        public string GetBrand()
        {
            return Brand.Dell.ToString();
        }
    }
}
