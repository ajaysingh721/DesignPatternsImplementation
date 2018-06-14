using DesignPatterns.Creational.Builder.IBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace DesignPatterns.Creational.Builder.Product
{
    public class ComputerSystem
    {
        public string RAM { get; set; }
        public string HDD { get; set; }
        public string Keyboard { get; set; }
        public string Mouse { get; set; }
        public string TouchScreen { get; set; }
    }
}