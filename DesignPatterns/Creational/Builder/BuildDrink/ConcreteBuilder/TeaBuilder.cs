using DesignPatterns.Creational.Builder.BuildDrink.IBuilder;
using DesignPatterns.Creational.Builder.BuildDrink.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.BuildDrink.ConcreteBuilder
{
    class TeaBuilder : IDrinkBuilder
    {

        Drink drink;

        TeaBuilder()
        {
            drink = new Drink("Tea");
        }

        public void AddPowder()
        {
            // Add tea powder
        }

        public void AddWater()
        {
            //Add water
        }

        public Drink getDrink()
        {
            return drink;
        }
    }
}
