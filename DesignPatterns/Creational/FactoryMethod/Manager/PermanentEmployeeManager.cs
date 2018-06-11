using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Manager
{
    public class PermanentEmployeeManager :IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetHouseAllowance()
        {
            return 1500;
        }

        public decimal GetPay()
        {
            return 8;
        }
    }
}
