using DesignPatterns.Creational.Builder.BuildDrink.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.BuildDrink.IBuilder
{
    interface IDrinkBuilder
    {
        void AddPowder();
        void AddWater();
        Drink getDrink();
    }
}
