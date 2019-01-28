using DesignPatterns.Creational.Builder.BuildDrink.IBuilder;
using DesignPatterns.Creational.Builder.BuildDrink.Product;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.BuildDrink.Director
{
    class DrinkMaker
    {
        public void BuildDrink(IDrinkBuilder drinkBuilder)
        {
            drinkBuilder.AddPowder();
            drinkBuilder.AddWater();
        }
    }
}
