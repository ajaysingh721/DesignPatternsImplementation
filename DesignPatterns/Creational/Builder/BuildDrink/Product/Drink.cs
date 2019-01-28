using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.BuildDrink.Product
{
    class Drink
    {
        private string _label { get; set; }

        public Drink(string lable)
        {
            this._label = _label;
        }

        public override string ToString()
        {
            return this._label;
        }
    }
}