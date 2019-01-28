using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Udemy
{
    public abstract class Database
    {
        public virtual DbCommand Command { get; set; }
        public virtual DbConnection Connection { get; set; }
    }
}
