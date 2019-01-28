using DesignPatterns.Creational.Builder.BuildDrink.IBuilder;
using DesignPatterns.Creational.Builder.BuildDrink.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.BuildDrink.ConcreteBuilder
{
    class CoffeeBuilder : IDrinkBuilder
    {
        Drink drink;

        public CoffeeBuilder()
        {
            drink = new Drink("Coffee");
        }

        public void AddPowder()
        {
            // Add coffee powder
        }

        public void AddWater()
        {
            // Add water
        }

        public Drink getDrink()
        {
            return drink;
        }
    }
}
